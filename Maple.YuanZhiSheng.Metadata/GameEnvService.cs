using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using Maple.UnityAssistant.Resource;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.YuanZhiSheng.Metadata
{
    public readonly partial struct GameEnvService(GameResourceCache cache)
    {
        GameResourceCache Cache { get; } = cache;
        ModelManager.Ptr_ModelManager Ptr_ModelManager { get; } = ModelManager.Ptr_ModelManager._INSTANCE;
        ILogger Logger => Cache.Context.Logger;

        public static GameEnvService Create(GameResourceCache cache)
        {
            return new GameEnvService(cache);
        }
        public static GameEnvService CreateThrowIfNotLoaded(GameResourceCache cache)
        {
            if (GameResourceCache.InGame() == false)
            {
                return GameException.ThrowIfNotLoaded<GameEnvService>();
            }
            return Create(cache);
        }

        public void LogModel()
        {
            var bag = this.GetModel<BagModel, BagModel.Ptr_BagModel>(this.Cache.Context.BagModel);
            var state = this.GetModel<StateModel, StateModel.Ptr_StateModel>(this.Cache.Context.StateModel);
            var player = this.GetModel<PlayerModel, PlayerModel.Ptr_PlayerModel>(this.Cache.Context.PlayerModel);
            Logger.LogInformation("Bag:{Bag:X8}, State:{State:X8}, Player:{Player:X8}", bag.Ptr, state.Ptr, player.Ptr);
        }

        #region Currency

        private static GameCurrencyInfoDTO GetCurrencyInfoImp(BagModel.Ptr_BagModel bag, ItemData.Ptr_ItemData item, GameCurrencyResource res)
        {
            var count = bag.GET_ITEM_NUM(item.ID);
            return new GameCurrencyInfoDTO
            {
                ObjectId = res.ObjectId,
                Currency = count,
            };
        }
        private bool TryGetCurrencyResource(GameCurrencyObjectDTO currencyObjectDTO, [MaybeNullWhen(false)] out GameCurrencyResource res)
        {
            res = this.Cache.CurrencyResources.Where(p => p.ObjectId == currencyObjectDTO.CurrencyObject && p.DisplayCategory == currencyObjectDTO.CurrencyCategory).FirstOrDefault();
            return res is not null;
        }
        private GameCurrencyResource GetCurrencyResource(GameCurrencyObjectDTO currencyObjectDTO)
        {
            if (TryGetCurrencyResource(currencyObjectDTO, out var res) == false)
            {
                return GameException.Throw<GameCurrencyResource>($"NOT FOUND:{currencyObjectDTO.CurrencyCategory}:{currencyObjectDTO.CurrencyObject}");
            }
            return res;
        }
        public GameCurrencyInfoDTO GetCurrencyInfo(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var res = GetCurrencyResource(currencyObjectDTO);
            var bag = this.GetBagModel();
            var item = new ItemData.Ptr_ItemData(res.ObjectPointer);
            return GetCurrencyInfoImp(bag, item, res);
        }
        public GameCurrencyInfoDTO UpdateCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var res = GetCurrencyResource(currencyModifyDTO);
            var item = new ItemData.Ptr_ItemData(res.ObjectPointer);
            var bag = this.GetBagModel();
            var count = bag.GET_ITEM_NUM(item.ID);
            bag.CHANGE_ITEM_NUM(item.ID, currencyModifyDTO.IntValue - count);
            return GetCurrencyInfoImp(bag, item, res);
        }
        #endregion

        #region Inventory

        private static GameInventoryInfoDTO GetInventoryInfoImp(BagModel.Ptr_BagModel bag, ItemData.Ptr_ItemData item, GameInventoryResource res)
        {
            var count = bag.GET_ITEM_NUM(item.ID);
            return new GameInventoryInfoDTO
            {
                ObjectId = res.ObjectId,
                InventoryCount = count,
            };
        }
        private bool TryGetInventoryResource(GameInventoryObjectDTO inventoryObjectDTO, [MaybeNullWhen(false)] out GameInventoryResource res)
        {
            res = this.Cache.InventoryResources.Where(p => p.ObjectId == inventoryObjectDTO.InventoryObject && p.DisplayCategory == inventoryObjectDTO.InventoryCategory).FirstOrDefault();
            return res is not null;
        }
        private GameInventoryResource GetInventoryResource(GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (TryGetInventoryResource(inventoryObjectDTO, out var res) == false)
            {
                return GameException.Throw<GameInventoryResource>($"NOT FOUND:{inventoryObjectDTO.InventoryCategory}:{inventoryObjectDTO.InventoryObject}");
            }
            return res;
        }
        public GameInventoryInfoDTO GetInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var res = GetInventoryResource(inventoryObjectDTO);
            return new GameInventoryInfoDTO() { ObjectId = res.ObjectId, InventoryCount = 0 };
        }
        public GameInventoryInfoDTO UpdateInventoryInfo(GameInventoryModifyDTO inventoryModifyDTO)
        {
            var res = GetInventoryResource(inventoryModifyDTO);
            var item = new ItemData.Ptr_ItemData(res.ObjectPointer);
            var bag = this.GetBagModel();
            var count = bag.GET_ITEM_NUM(item.ID);
            bag.CHANGE_ITEM_NUM(item.ID, inventoryModifyDTO.InventoryCount - count);
            return GetInventoryInfoImp(bag, item, res);
        }
        #endregion

        #region Character
        bool TryGetCharacterRes(GameCharacterObjectDTO characterObjectDTO, [MaybeNullWhen(false)] out GameCharacterResource res)
        {
            res = this.Cache.CharacterResources.Where(p => p.ObjectId == characterObjectDTO.CharacterId && p.DisplayCategory == characterObjectDTO.CharacterCategory).FirstOrDefault();
            return res is not null;
        }
        GameCharacterResource GetCharacterRes(GameCharacterObjectDTO characterObjectDTO)
        {
            if (!TryGetCharacterRes(characterObjectDTO, out var res))
            {
                GameException.Throw<GameCharacterResource>($"NOT FOUND:{characterObjectDTO.CharacterCategory}:{characterObjectDTO.CharacterId}");
            }
            return res;

        }

        IEnumerable<GameSwitchDisplayDTO> GetRoleInfo(PlayerModel.Ptr_PlayerModel playerModel, RoleInfo.Ptr_RoleInfo roleInfo, PMonoString roleId)
        {
            if (roleId.AsReadOnlySpan().SequenceEqual(this.Cache.MainPlayerId.AsReadOnlySpan()))
            {
                yield break;
            }
            foreach (var item in roleInfo.EnumRoleInfoReader())
            {
                var boolType = Boolean.FalseString.Equals(item.Value, StringComparison.OrdinalIgnoreCase) ||
                    Boolean.TrueString.Equals(item.Key, StringComparison.OrdinalIgnoreCase);
                yield return new GameSwitchDisplayDTO
                {
                    ObjectId = item.Key,
                    UIType = (int)(boolType ? EnumGameSwitchUIType.Switches  : EnumGameSwitchUIType.TextEditor),
                    DisplayName = item.Name,
                    DisplayDesc = item.Description,
                    ContentValue = item.Value,
                    // DisplayImage = item.Description,

                };
            }
        }
        IEnumerable<GameSwitchDisplayDTO> GetPartnerInfo(PlayerModel.Ptr_PlayerModel playerModel, RoleInfo.Ptr_RoleInfo roleInfo, PMonoString roleId)
        {
            float[] attDatas = [.. playerModel.GET_ROLE_ATTRIBUTE_VALUES(roleId).AsSpan()];
            foreach (var att in this.Cache.PlayerAttributeDatas)
            {
                var pAtt = new AttributeData.Ptr_AttributeData(att.ObjectPointer);
                var t = attDatas.ElementAtOrDefault(pAtt.IDX);
                yield return new GameSwitchDisplayDTO
                {
                    ObjectId = att.ObjectId,
                    UIType = (int)EnumGameSwitchUIType.TextEditor,
                    DisplayName = $"成长.{att.DisplayName}",
                    DisplayDesc = att.DisplayDesc,
                    DisplayImage = att.DisplayImage,
                    DecimalValue = new decimal(t),
                };
            }

            float[] battleDatas = [.. playerModel.GET_ROLE_BATTLE_ATTRIBUTE_VALUES(roleId).AsSpan()];
            foreach (var att in this.Cache.BattleAttributeDatas)
            {
                var pAtt = new BattleAttributeData.Ptr_BattleAttributeData(att.ObjectPointer);
                var t = battleDatas.ElementAtOrDefault(pAtt.IDX);
                yield return new GameSwitchDisplayDTO
                {
                    ObjectId = att.ObjectId,
                    UIType = (int)EnumGameSwitchUIType.TextEditor,

                    DisplayName = $"战斗.{att.DisplayName}",
                    DisplayDesc = att.DisplayDesc,
                    DisplayImage = att.DisplayImage,
                    DecimalValue = new decimal(t),
                };
            }

        }
        IEnumerable<GameSwitchDisplayDTO> GetMainPlay(PlayerModel.Ptr_PlayerModel playerModel, RoleInfo.Ptr_RoleInfo roleInfo, PMonoString roleId)
        {
            if (!roleId.AsReadOnlySpan().SequenceEqual(this.Cache.MainPlayerId.AsReadOnlySpan()))
            {
                yield break;
            }
        }


        public GameCharacterStatusDTO GetCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            var res = GetCharacterRes(characterObjectDTO);
            RoleData.Ptr_RoleData roleData = new(res.ObjectPointer);
            var playerModel = this.GetPlayerModel();
            var id = roleData.ID;
            var roleInfo = playerModel.GET_ROLE_INFO(id);
            return new GameCharacterStatusDTO()
            {
                ObjectId = characterObjectDTO.CharacterId,
                CharacterAttributes = [
                    ..GetPartnerInfo(playerModel, roleInfo, id),
                    ..GetMainPlay(playerModel, roleInfo, id ),
                    ..GetRoleInfo(playerModel, roleInfo ,id),
                    ]


            };
        }
        public GameCharacterStatusDTO UpdateCharacterStatus(GameCharacterModifyDTO characterModifyDTO) 
        {
            return GetCharacterStatus(characterModifyDTO);
        }
        #endregion

        #region Model

        private T GetModel<TREF, T>(TREF classMetadataCollector)
            where TREF : ClassMetadataCollector<T>
            where T : unmanaged, IPtrMetadata
        {
            var context = this.Cache.Context;
            foreach (var model in this.Ptr_ModelManager._MODEL_DICT.AsRefEnumerable())
            {
                var pMonoObject = model.Value;
                var klass = context.RuntimeContext.RuntiemProvider.GetMonoClass(pMonoObject);
                if (classMetadataCollector.ClassMetadata.ClassInfo.Pointer == klass)
                {
                    return Unsafe.As<PMonoObject, T>(ref pMonoObject);
                }

            }
            return default;
        }
        private BagModel.Ptr_BagModel GetBagModel()
        {
            return GetModel<BagModel, BagModel.Ptr_BagModel>(this.Cache.Context.BagModel);
        }
        private StateModel.Ptr_StateModel GetStateModel()
        {
            return GetModel<StateModel, StateModel.Ptr_StateModel>(this.Cache.Context.StateModel);
        }
        private PlayerModel.Ptr_PlayerModel GetPlayerModel()
        {
            return GetModel<PlayerModel, PlayerModel.Ptr_PlayerModel>(this.Cache.Context.PlayerModel);
        }
        #endregion

    }
}

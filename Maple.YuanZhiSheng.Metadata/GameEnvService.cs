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

        private static GameCurrencyInfoDTO GetCurrencyInfoImp(BagModel.Ptr_BagModel bag, ItemData.Ptr_ItemData item, GameCurrencyResource res)
        {
            var count = bag.GET_ITEM_NUM(item.ID);
            return new GameCurrencyInfoDTO
            {
                ObjectId = res.ObjectId,
                Currency = count,
            };
        }
        private bool TryGetCurrencyResource(GameCurrencyObjectDTO currencyObjectDTO, [MaybeNullWhen(false)]out GameCurrencyResource res)
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
    }
}

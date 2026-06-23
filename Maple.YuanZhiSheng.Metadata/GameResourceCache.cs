using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.UnityAssistant.Resource;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using static Maple.YuanZhiSheng.Metadata.LocalizationManager;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// 
    /// </summary>
    public class GameResourceCache(GameMetadataContext context)
    {
        public static bool DEBUG { get; } = true;
        public GameMetadataContext Context { get; } = context;
        public required GameCurrencyResource[] CurrencyResources { get; init; }
        public required GameInventoryResource[] InventoryResources { get; init; }
        public required GameCharacterResource[] CharacterResources { get; init; }

        public required GameObjectResource[] PlayerAttributeDatas { get; init; }
        public required GameObjectResource[] BattleAttributeDatas { get; init; }
        public required GameObjectResource[] PlayerPersonalityDatas { get; init; }
        public required PMonoString MainPlayerId { get; init; }
        public required WinManager.Ptr_WinManager Ptr_WinManager { get; init; }

        private static void WaitForGameReady()
        {
            SpinWait.SpinUntil(() => GameConfig.Ptr_GameConfig.MAIN_PLAYER_ID.Valid());
            SpinWait.SpinUntil(() => MC.Ptr_MC._INSTANCE.IsNotNull());
            SpinWait.SpinUntil(() => LocalizationManager.Ptr_LocalizationManager._INSTANCE.IsNotNull());
            SpinWait.SpinUntil(() => AttributeData.Ptr_AttributeData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => BattleAttributeData.Ptr_BattleAttributeData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => CareerData.Ptr_CareerData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => PlayerDesignationData.Ptr_PlayerDesignationData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => PersonalityData.Ptr_PersonalityData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => ItemData.Ptr_ItemData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => BattleSkillData.Ptr_BattleSkillData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => RoleData.Ptr_RoleData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => PartnerData.Ptr_PartnerData.LIST.IsNotNull());
            SpinWait.SpinUntil(() => WinManager.Ptr_WinManager._INSTANCE.IsNotNull());

        }

        public static GameResourceCache Create(GameMetadataContext context)
        {
            WaitForGameReady();


            Ptr_LocalizationManager localizationManager = LocalizationManager.Ptr_LocalizationManager._INSTANCE;

            GameObjectResource[] playerAttributeDatas = [.. LoadAllAttributeData(localizationManager)];
            foreach (var res in playerAttributeDatas)
            {
                context.Log(res);
            }

            GameObjectResource[] battleAttributeDatas = [.. LoadAllBattleAttributeData(localizationManager)];
            foreach (var res in battleAttributeDatas)
            {
                context.Log(res);
            }

            GameObjectResource[] playerCareerDatas = [.. LoadAllCareerData(localizationManager)];
            foreach (var res in playerCareerDatas)
            {
                context.Log(res);
            }

            GameObjectResource[] playerDesignationDatas = [.. LoadAllPlayerDesignationData(localizationManager)];
            foreach (var reg in playerDesignationDatas)
            {
                context.Log(reg);
            }

            GameObjectResource[] playerPersonalityDatas = [.. LoadAllPersonalityData(localizationManager)];
            foreach (var reg in playerPersonalityDatas)
            {
                context.Log(reg);
            }
            GameObjectDisplayDTO[] gameObjects = [.. LoadAllItemData(localizationManager)];

            GameCurrencyResource[] currencyDatas = [.. gameObjects.Where(p => p is GameCurrencyResource).Cast<GameCurrencyResource>()];
            foreach (var reg in currencyDatas)
            {
                context.Log(reg);
            }
            GameInventoryResource[] inventoryDatas = [.. gameObjects.Where(p => p is GameInventoryResource).Cast<GameInventoryResource>()];
            foreach (var reg in inventoryDatas)
            {
                context.Log(reg);
            }

            GameSkillResource[] battleSkillDatas = [.. LoadAllBattleSkillData(localizationManager)];
            foreach (var reg in battleSkillDatas)
            {
                context.Log(reg);
            }
            var mainPlayerId = GameConfig.Ptr_GameConfig.MAIN_PLAYER_ID;
            GameCharacterResource[] roleDatas = [.. LoadAllRoleData(localizationManager, mainPlayerId)];
            foreach (var reg in roleDatas)
            {
                context.Log(reg);
            }

            var cache = new GameResourceCache(context)
            {
                CurrencyResources = currencyDatas,
                InventoryResources = inventoryDatas,
                CharacterResources = roleDatas,

                PlayerAttributeDatas = playerAttributeDatas,
                PlayerPersonalityDatas = playerPersonalityDatas,
                BattleAttributeDatas = battleAttributeDatas,

                Ptr_WinManager = WinManager.Ptr_WinManager._INSTANCE,
                MainPlayerId = mainPlayerId,
            };
            return cache;
        }


        public void ShowMsg(string msg)
        {
            var pMsg = this.Context.TPin(msg, out var gc);
            using (gc)
            {
                this.Ptr_WinManager.SHOW_TIP(TipType.Message, pMsg);
            }
        }

        public static bool InGame()
        {
            var gameProcessManager = GameProcessManager.Ptr_GameProcessManager._INSTANCE;
            if (gameProcessManager.IsNull())
            {
                return false;
            }
            return gameProcessManager._CURR_SCENE_STATE != SceneState.None;
        }

        static IEnumerable<GameObjectResource> LoadAllAttributeData(Ptr_LocalizationManager localizationManager)
        {
            var list = AttributeData.Ptr_AttributeData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                var desc = localizationManager.GetText(att.DESCRIPTION);
                yield return new GameObjectResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //DisplayImage = default,
                    DisplayCategory = nameof(AttributeData),
                    DisplayDesc = desc,
                    DisplayName = name,
                };
            }
        }
        static IEnumerable<GameObjectResource> LoadAllBattleAttributeData(Ptr_LocalizationManager localizationManager)
        {
            var list = BattleAttributeData.Ptr_BattleAttributeData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                var desc = localizationManager.GetText(att.DESCRIPTION);
                yield return new GameObjectResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //DisplayImage = default,
                    DisplayCategory = nameof(BattleAttributeData),
                    DisplayDesc = desc,
                    DisplayName = name,
                };
            }
        }
        static IEnumerable<GameObjectResource> LoadAllCareerData(Ptr_LocalizationManager localizationManager)
        {
            var list = CareerData.Ptr_CareerData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                //  var desc = localizationManager.GetText(att.DESCRIPTION);
                yield return new GameObjectResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //DisplayImage = default,
                    DisplayCategory = nameof(CareerData),
                    //  DisplayDesc = desc,
                    DisplayName = name,
                };
            }

        }
        static IEnumerable<GameObjectResource> LoadAllPlayerDesignationData(Ptr_LocalizationManager localizationManager)
        {
            var list = PlayerDesignationData.Ptr_PlayerDesignationData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                var desc = localizationManager.GetText(att.DESCRIPTION);
                yield return new GameObjectResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //DisplayImage = default,
                    DisplayCategory = nameof(PlayerDesignationData),
                    DisplayDesc = desc,
                    DisplayName = name,
                };
            }

        }
        static IEnumerable<GameObjectResource> LoadAllPersonalityData(Ptr_LocalizationManager localizationManager)
        {
            var list = PersonalityData.Ptr_PersonalityData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                //    var desc = localizationManager.GetText(att.DESCRIPTION);
                yield return new GameObjectResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //DisplayImage = default,
                    DisplayCategory = nameof(PersonalityData),
                    //    DisplayDesc = desc ,
                    DisplayName = name,
                };
            }

        }
        static IEnumerable<GameObjectDisplayDTO> LoadAllItemData(Ptr_LocalizationManager localizationManager)
        {
            var list = ItemData.Ptr_ItemData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.ITEM_NAME);
                var desc = localizationManager.GetText(att.ITEM_DESCRIPTION);
                var image = att.ITEM_ICON.ToString();
                var type = att.ITEM_TYPE;
                var subtype = att.ITEM_SUB_TYPE;

                if (IsInventory(type, subtype))
                {
                    yield return new GameInventoryResource()
                    {
                        ObjectId = id.ToString()!,
                        ObjectPointer = att,
                        //ImagePointer = default,
                        DisplayImage = image,
                        DisplayCategory = type.ToString(),
                        DisplayDesc = desc,
                        DisplayName = name,
                    };
                }
                else
                {
                    yield return new GameCurrencyResource()
                    {
                        ObjectId = id.ToString()!,
                        ObjectPointer = att,
                        //ImagePointer = default,
                        DisplayImage = image,
                        DisplayCategory = type.ToString(),
                        DisplayDesc = desc,
                        DisplayName = name,
                    };
                }

            }

            static bool IsInventory(ItemType itemType, ConsumeItemSubType itemSubType)
            {
                if (itemType == ItemType.Consume)
                {
                    return itemSubType switch
                    {
                        ConsumeItemSubType.Medicine => true,
                        ConsumeItemSubType.Missile => true,
                        _ => false,
                    };
                }
                return itemType switch
                {
                    ItemType.Weapon => true,
                    ItemType.Armor => true,
                    ItemType.Accessory => true,
                    ItemType.SkillBook => true,
                    _ => false,
                };

            }

        }
        static IEnumerable<GameSkillResource> LoadAllBattleSkillData(Ptr_LocalizationManager localizationManager)
        {
            var list = BattleSkillData.Ptr_BattleSkillData.LIST;
            if (list.IsNull())
            {
                yield break;
            }

            foreach (var att in list.AsEnumerable())
            {
                var id = att.ID;
                // var idx = att.IDX;
                var name = localizationManager.GetText(att.NAME);
                //      var desc = localizationManager.GetText(att.DESCRIPTION);
                //   var image = att.ICON.ToString();
                yield return new GameSkillResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    //       DisplayImage = image,
                    DisplayCategory = nameof(BattleSkillData),
                    //  DisplayDesc = desc,
                    DisplayName = name,
                };
            }

        }
        static IEnumerable<GameCharacterResource> LoadAllRoleData(Ptr_LocalizationManager localizationManager, PMonoString mainPlayerId)
        {
            PMonoString[] partnerList = [.. LoadAllPartnerData()];

            foreach (var role in RoleData.Ptr_RoleData.LIST.AsEnumerable())
            {
                var id = role.ID;
                var partner = partnerList.Any(p => p.AsReadOnlySpan().SequenceEqual(id.AsReadOnlySpan())) || id.AsReadOnlySpan().SequenceEqual(mainPlayerId.AsReadOnlySpan());
                // var idx = role.IDX;
                var name = localizationManager.GetText(role.NAME);
                var desc = localizationManager.GetText(role.TAG);
                var image = role.EX_HEAD_ICON.ToString();

                yield return new GameCharacterResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = role,
                    DisplayImage = image,
                    DisplayCategory = partner ? nameof(PartnerData) : nameof(RoleData),
                    DisplayDesc = desc,
                    DisplayName = name,

                };
            }


        }
        static IEnumerable<PMonoString> LoadAllPartnerData()
        {
            foreach (var p in PartnerData.Ptr_PartnerData.LIST.AsEnumerable())
            {
                var id = p.ID;

                yield return id;
            }
        }
    }

    internal static class GameResourceCacheExtensions
    {
        public static void Log<T>(this GameMetadataContext context, T res)
             where T : GameObjectDisplayDTO, IGameCommonResource
        {
            if (!GameResourceCache.DEBUG)
            {
                return;
            }

            var logger = context.Logger;
            if (logger.IsEnabled(LogLevel.Information))
            {
                logger.LogInformation("[{Type}] Cate:{Cate}, Object:{Object}, Name:{Name}, Desc:{Desc} Pointer:{Pointer:X8}",
                    typeof(T).Name, res.DisplayCategory, res.ObjectId, res.DisplayName, res.DisplayDesc, res.ObjectPointer);
            }
        }


        public static string? GetText(this Ptr_LocalizationManager localizationManager, PMonoString key)
        {
            var text = localizationManager.GET(key);
            if (text.AsReadOnlySpan().IsEmpty)
            {
                return key.ToString();
            }
            return text.ToString();
        }
    }
}

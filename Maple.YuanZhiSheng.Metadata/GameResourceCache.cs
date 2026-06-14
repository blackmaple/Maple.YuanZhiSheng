using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.UnityAssistant.Resource;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static Maple.YuanZhiSheng.Metadata.LocalizationManager;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// 
    /// </summary>
    public class GameResourceCache(GameMetadataContext context)
    {
        public static bool DEBUG { get; } = true;
        public GameMetadataContext Context { get; } = context;
        public required GameInventoryResource[] InventoryResources { get; set; }


        public static GameResourceCache Create(GameMetadataContext context)
        {

            SpinWait.SpinUntil(() => MC.Ptr_MC._INSTANCE.IsNotNull());
            // SpinWait.SpinUntil(() => LocalizationManager.Ptr_LocalizationManager._INSTANCE.IsNotNull());


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

            GameInventoryResource[] inventoryDatas = [.. LoadAllItemData(localizationManager)];
            foreach (var reg in inventoryDatas)
            {
                context.Log(reg);
            }

            GameSkillResource[] battleSkillDatas = [.. LoadAllBattleSkillData(localizationManager)];
            foreach (var reg in battleSkillDatas)
            {
                context.Log(reg);
            }

            var cache = new GameResourceCache(context)
            {
                InventoryResources = inventoryDatas,

            };
            return cache;
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
        static IEnumerable<GameInventoryResource> LoadAllItemData(Ptr_LocalizationManager localizationManager)
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
                yield return new GameInventoryResource()
                {
                    ObjectId = id.ToString()!,
                    ObjectPointer = att,
                    //ImagePointer = default,
                    DisplayImage = image,
                    DisplayCategory = nameof(ItemData),
                    DisplayDesc = desc,
                    DisplayName = name,
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

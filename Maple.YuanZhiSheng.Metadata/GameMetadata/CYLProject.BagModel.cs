using Maple.MonoGameAssistant.Core;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."BagModel"]
    /// [CYLProject.BaseModel]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BagModel>, Ptr_BagModel>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "BagModel", "CYLProject.BagModel")]
    public partial class BagModel
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BagModel(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BagModel(System.IntPtr ptr) => new Ptr_BagModel(ptr);
            public static implicit operator System.IntPtr(Ptr_BagModel ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BagModel ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."BagModel"]
        /// </summary>
        partial struct Ptr_BagModel
        {
            /// <summary>
            /// 0x0 System.Int32 ItemCntCap
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 ITEM_CNT_CAP = 999999999; 
*/
            /// <summary>
            /// 0x10 CYLProject.BagSave _bagSave
            /// class ["Assembly-CSharp.dll"."CYLProject"."BagSave"]
            /// </summary>
            /// <returns>class CYLProject.BagSave</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_bagSave", "CYLProject.BagSave")]
            public partial nint _BAG_SAVE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<CYLProject.LittleGameType , System.Collections.Generic.List<System.String>> _littleGameMatDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.LittleGameType , System.Collections.Generic.List<System.String>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_littleGameMatDict", "System.Collections.Generic.Dictionary<CYLProject.LittleGameType,System.Collections.Generic.List<System.String>>")]
            public partial nint _LITTLE_GAME_MAT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.HashSet<System.String> _specialMats
            /// class ["System.Core.dll"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_specialMats", "System.Collections.Generic.HashSet<System.String>")]
            public partial nint _SPECIAL_MATS { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<DB.DBIdInt> _defaultCosts
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.DBIdInt></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_defaultCosts", "System.Collections.Generic.List<DB.DBIdInt>")]
            public partial nint _DEFAULT_COSTS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."BagModel"]
        /// </summary>
        partial struct Ptr_BagModel
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AddItems(System.Collections.Generic.Dictionary<System.String , System.Int32> rewards, System.Boolean showTip)
            /// </summary>
            /// <param name = "rewards">class System.Collections.Generic.Dictionary<System.String , System.Int32></param>
            /// <param name = "showTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Int32>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void ADD_ITEMS(nint rewards, System.Boolean showTip); 
*/
            /// <summary>
            ///   System.Void BuyBack(System.Collections.Generic.Dictionary<System.String , System.Int32> buybackItems, System.Collections.Generic.List<System.String> buybackSaveItems)
            /// </summary>
            /// <param name = "buybackItems">class System.Collections.Generic.Dictionary<System.String , System.Int32></param>
            /// <param name = "buybackSaveItems">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuyBack", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Int32>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
           public partial void BUY_BACK(nint buybackItems, nint buybackSaveItems); 
*/
            /// <summary>
            ///   System.Void BuyShopItem(System.String shopId, System.Int32 shopLevel, System.String shopItemId, System.Int32 count)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <param name = "shopLevel">struct System.Int32</param>
            /// <param name = "shopItemId">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuyShopItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial void BUY_SHOP_ITEM(nint shopId, System.Int32 shopLevel, nint shopItemId, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void BuyTavernShop(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuyTavernShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public partial void BUY_TAVERN_SHOP(nint id); 
*/
            /// <summary>
            ///   System.Boolean ChangeItemNum(System.String id, System.Int32 cnt, System.Boolean showTip, System.String roleId)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "cnt">struct System.Int32</param>
            /// <param name = "showTip">struct System.Boolean</param>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeItemNum", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            public partial System.Boolean CHANGE_ITEM_NUM(PMonoString id, System.Int32 cnt, System.Boolean showTip = false, PMonoString roleId = default); 

            /// <summary>
            ///   System.Boolean CheckLittleGameEnergy()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckLittleGameEnergy", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CHECK_LITTLE_GAME_ENERGY(); 
*/
            /// <summary>
            ///   System.Void ClaimCareerReward()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimCareerReward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLAIM_CAREER_REWARD(); 
*/
            /// <summary>
            ///   System.Boolean CostEnergy(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostEnergy", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean COST_ENERGY(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void CreateProduce(System.String produceId)
            /// </summary>
            /// <param name = "produceId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateProduce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CREATE_PRODUCE(nint produceId); 
*/
            /// <summary>
            ///   System.Void CreateProduce(System.String produceId, System.Collections.Generic.List<System.String> selectEffects, System.Collections.Generic.List<System.String> smats, System.Boolean free)
            /// </summary>
            /// <param name = "produceId">class System.String</param>
            /// <param name = "selectEffects">class System.Collections.Generic.List<System.String></param>
            /// <param name = "smats">class System.Collections.Generic.List<System.String></param>
            /// <param name = "free">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateProduce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void CREATE_PRODUCE(nint produceId, nint selectEffects, nint smats, System.Boolean free); 
*/
            /// <summary>
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Int32 get_Energy()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Energy", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ENERGY(); 
*/
            /// <summary>
            ///   System.Int32 get_Gold()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Gold", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_GOLD(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Int32> get_ItemCntDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemCntDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_CNT_DICT(); 
*/
            /// <summary>
            ///   System.Int32 get_Mood()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Mood", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MOOD(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , CYLProject.SaveItemInfo> get_SaveItemDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.SaveItemInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveItemDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.SaveItemInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_ITEM_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Int32> get_SellItemCntDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SellItemCntDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SELL_ITEM_CNT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , CYLProject.SaveItemInfo> get_SellSaveItemDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.SaveItemInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SellSaveItemDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.SaveItemInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SELL_SAVE_ITEM_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_TavernShopList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TavernShopList", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TAVERN_SHOP_LIST(); 
*/
            /// <summary>
            ///   System.Int32 GetItemNum(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_ITEM_NUM(PMonoString id); 

            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetRandomItemsShuffle(System.Collections.Generic.List<System.String> source, System.Int32 count)
            /// </summary>
            /// <param name = "source">class System.Collections.Generic.List<System.String></param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomItemsShuffle", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_RANDOM_ITEMS_SHUFFLE(nint source, System.Int32 count); 
*/
            /// <summary>
            ///   CYLProject.SaveItemInfo GetSaveItemInfo(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class CYLProject.SaveItemInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveItemInfo", "CYLProject.SaveItemInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SAVE_ITEM_INFO(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetSellItemNum(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSellItemNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_SELL_ITEM_NUM(nint id); 
*/
            /// <summary>
            ///   CYLProject.SaveItemInfo GetSellSaveItemInfo(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class CYLProject.SaveItemInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSellSaveItemInfo", "CYLProject.SaveItemInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SELL_SAVE_ITEM_INFO(nint id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetShopAllBuyItems(System.String shopId, System.Int32 level)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShopAllBuyItems", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_SHOP_ALL_BUY_ITEMS(nint shopId, System.Int32 level); 
*/
            /// <summary>
            ///   System.Single GetShopBuyItemDiscount(System.String shopId, System.Int32 level, System.String shopItemId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "shopItemId">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShopBuyItemDiscount", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial System.Single GET_SHOP_BUY_ITEM_DISCOUNT(nint shopId, System.Int32 level, nint shopItemId); 
*/
            /// <summary>
            ///   System.Int32 GetShopItemBuyCount(System.String shopId, System.Int32 level, System.String shopItemId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "shopItemId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShopItemBuyCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial System.Int32 GET_SHOP_ITEM_BUY_COUNT(nint shopId, System.Int32 level, nint shopItemId); 
*/
            /// <summary>
            ///   System.Int32 GetShopRefreshCount(System.String shopId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShopRefreshCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_SHOP_REFRESH_COUNT(nint shopId); 
*/
            /// <summary>
            ///   System.Boolean GetTavernShopIsBought(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTavernShopIsBought", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_TAVERN_SHOP_IS_BOUGHT(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetUseItemCount(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUseItemCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_USE_ITEM_COUNT(nint id); 
*/
            /// <summary>
            ///   System.Void GMAddItemNum(System.String id, System.Int32 cnt)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "cnt">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GMAddItemNum", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void GM_ADD_ITEM_NUM(nint id, System.Int32 cnt); 
*/
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT(); 
*/
            /// <summary>
            ///   System.Void InitShop(System.String shopId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void INIT_SHOP(nint shopId); 
*/
            /// <summary>
            ///   System.Void RefreshShop(System.String shopId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REFRESH_SHOP(nint shopId); 
*/
            /// <summary>
            ///   System.Void RefreshShopAllItems(System.String shopId)
            /// </summary>
            /// <param name = "shopId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshShopAllItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REFRESH_SHOP_ALL_ITEMS(nint shopId); 
*/
            /// <summary>
            ///   System.Void Sell(System.Collections.Generic.Dictionary<System.String , System.Int32> sellItems, System.Collections.Generic.List<System.String> sellSaveItems)
            /// </summary>
            /// <param name = "sellItems">class System.Collections.Generic.Dictionary<System.String , System.Int32></param>
            /// <param name = "sellSaveItems">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sell", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Int32>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 1)]
            public partial void SELL(nint sellItems, nint sellSaveItems); 
*/
            /// <summary>
            ///   System.Void UseConsume(System.String id, System.Int32 count, System.String roleId)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseConsume", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void USE_CONSUME(nint id, System.Int32 count, nint roleId); 
*/
            /// <summary>
            ///   System.Boolean UseItemNum(System.String id, System.Int32 cnt, System.Boolean showTip, System.String roleId)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "cnt">struct System.Int32</param>
            /// <param name = "showTip">struct System.Boolean</param>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseItemNum", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            public partial System.Boolean USE_ITEM_NUM(nint id, System.Int32 cnt, System.Boolean showTip, nint roleId); 
*/
            /// <summary>
            ///   System.Void UseSaveItem(System.String saveId, System.Boolean showTips)
            /// </summary>
            /// <param name = "saveId">class System.String</param>
            /// <param name = "showTips">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseSaveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void USE_SAVE_ITEM(nint saveId, System.Boolean showTips); 
*/
            /// <summary>
            ///   System.Void UseTreasureMap(System.String id, System.Int32 count)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseTreasureMap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void USE_TREASURE_MAP(nint id, System.Int32 count); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."CYLProject"."BaseModel"]
        /// </summary>
        partial struct Ptr_BagModel
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT(); 
*/
        }
    }
}
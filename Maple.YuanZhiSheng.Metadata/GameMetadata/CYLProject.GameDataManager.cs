namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."GameDataManager"]
    /// [BaseManager<CYLProject.GameDataManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameDataManager>, Ptr_GameDataManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "GameDataManager", "CYLProject.GameDataManager")]
    public partial class GameDataManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameDataManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameDataManager(System.IntPtr ptr) => new Ptr_GameDataManager(ptr);
            public static implicit operator System.IntPtr(Ptr_GameDataManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GameDataManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameDataManager"]
        /// </summary>
        partial struct Ptr_GameDataManager
        {
            /// <summary>
            /// 0x0 System.String SpriteLoadPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint SPRITE_LOAD_PATH = Assets/Data/DataSet/SpriteLoadPath.bytes; 
*/
            /// <summary>
            /// 0x0 System.String Pattern
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint PATTERN = \{(\w+)\}; 
*/
            /// <summary>
            /// 0x0 CYLProject.GameDataManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameDataManager"]
            /// </summary>
            /// <returns>class CYLProject.GameDataManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.GameDataManager")]
            public static partial nint _INSTANCE { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Boolean <InitCompleted>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<InitCompleted>k__BackingField", "System.Boolean")]
            public partial System.Boolean INIT_COMPLETED { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<System.String , System.String> SpriteLoadDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SpriteLoadDict", "System.Collections.Generic.Dictionary<System.String,System.String>")]
            public partial nint SPRITE_LOAD_DICT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData> <AttributeIdxDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeIdxDict>k__BackingField", "System.Collections.Generic.Dictionary<System.Int32,DB.AttributeData>")]
            public partial nint ATTRIBUTE_IDX_DICT { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.Int32 , System.String> <AttributeIdxIdDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeIdxIdDict>k__BackingField", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
            public partial nint ATTRIBUTE_IDX_ID_DICT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData> <BattleAttributeIdxDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleAttributeIdxDict>k__BackingField", "System.Collections.Generic.Dictionary<System.Int32,DB.BattleAttributeData>")]
            public partial nint BATTLE_ATTRIBUTE_IDX_DICT { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>> <StudyCateDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyCateDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.StudyData>>")]
            public partial nint STUDY_CATE_DICT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>> <VisitDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<VisitDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.ScheduleVisitData>>")]
            public partial nint VISIT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>> <RoleAttributeDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoleAttributeDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleAttributeData>>")]
            public partial nint ROLE_ATTRIBUTE_DICT { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>> <ItemDataListDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ItemDataListDict>k__BackingField", "System.Collections.Generic.Dictionary<CYLProject.ItemType,System.Collections.Generic.List<DB.ItemData>>")]
            public partial nint ITEM_DATA_LIST_DICT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>> <BattleRoleSkillDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleRoleSkillDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.BattleSkillData>>")]
            public partial nint BATTLE_ROLE_SKILL_DICT { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>> <BattleSkillLvDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleSkillLvDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,DB.BattleSkillLevelData>>")]
            public partial nint BATTLE_SKILL_LV_DICT { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData> <CalendarIndexDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CalendarIndexDict>k__BackingField", "System.Collections.Generic.Dictionary<System.Int32,DB.CalendarData>")]
            public partial nint CALENDAR_INDEX_DICT { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>> <RoleBattleTalentDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoleBattleTalentDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleTalentData>>")]
            public partial nint ROLE_BATTLE_TALENT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>> <ShopLevelDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ShopLevelDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<DB.ShopLevelData>>>")]
            public partial nint SHOP_LEVEL_DICT { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String> <DayRolePointDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DayRolePointDict>k__BackingField", "System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey,System.String>")]
            public partial nint DAY_ROLE_POINT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> <RoleMapEventDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoleMapEventDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>")]
            public partial nint ROLE_MAP_EVENT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> <MapOneEventDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MapOneEventDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>")]
            public partial nint MAP_ONE_EVENT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> <MapTwoEventDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MapTwoEventDict>k__BackingField", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>")]
            public partial nint MAP_TWO_EVENT_DICT { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Collections.Generic.Dictionary<System.Int32 , System.Int32> <LevelExpDict>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LevelExpDict>k__BackingField", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>")]
            public partial nint LEVEL_EXP_DICT { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 _maxLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_maxLevel", "System.Int32")]
            public partial System.Int32 _MAX_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Text.StringBuilder _strbd
            /// class ["mscorlib.dll"."System.Text"."StringBuilder"]
            /// </summary>
            /// <returns>class System.Text.StringBuilder</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_strbd", "System.Text.StringBuilder")]
            public partial nint _STRBD { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Text.StringBuilder _strbd1
            /// class ["mscorlib.dll"."System.Text"."StringBuilder"]
            /// </summary>
            /// <returns>class System.Text.StringBuilder</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_strbd1", "System.Text.StringBuilder")]
            public partial nint _STRBD1 { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Collections.Generic.Dictionary<System.String , System.Single> _attributeFormatDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_attributeFormatDict", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial nint _ATTRIBUTE_FORMAT_DICT { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Int32 calendarMinIdx
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("calendarMinIdx", "System.Int32")]
            public partial System.Int32 CALENDAR_MIN_IDX { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Int32 calendarMaxIdx
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("calendarMaxIdx", "System.Int32")]
            public partial System.Int32 CALENDAR_MAX_IDX { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Data.DataTable dataTable
            /// class ["System.Data.dll"."System.Data"."DataTable"]
            /// </summary>
            /// <returns>class System.Data.DataTable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dataTable", "System.Data.DataTable")]
            public partial nint DATA_TABLE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameDataManager"]
        /// </summary>
        partial struct Ptr_GameDataManager
        {
            /// <summary>
            /// static  System.Collections.Generic.List<T> GetRandomElementsSmart(T[] array, System.Int32 n)
            /// </summary>
            /// <param name = "array">class T[]</param>
            /// <param name = "n">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomElementsSmart", "System.Collections.Generic.List<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_RANDOM_ELEMENTS_SMART(nint array, System.Int32 n); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Single CalculateBattleAttribute(System.Int32 bAttriIdx, System.Single baseValue, System.Collections.Generic.Dictionary<System.String , System.Single> attributeDict, System.Boolean monster)
            /// </summary>
            /// <param name = "bAttriIdx">struct System.Int32</param>
            /// <param name = "baseValue">struct System.Single</param>
            /// <param name = "attributeDict">class System.Collections.Generic.Dictionary<System.String , System.Single></param>
            /// <param name = "monster">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CalculateBattleAttribute", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Single>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial System.Single CALCULATE_BATTLE_ATTRIBUTE(System.Int32 bAttriIdx, System.Single baseValue, nint attributeDict, System.Boolean monster); 
*/
            /// <summary>
            ///   System.Single[] CalculateBattleAttributes(System.Single[] baseValues, System.Single[] attributeValues, System.Boolean monster)
            /// </summary>
            /// <param name = "baseValues">class System.Single[]</param>
            /// <param name = "attributeValues">class System.Single[]</param>
            /// <param name = "monster">struct System.Boolean</param>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CalculateBattleAttributes", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint CALCULATE_BATTLE_ATTRIBUTES(nint baseValues, nint attributeValues, System.Boolean monster); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData> get_AttributeIdxDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeIdxDict", "System.Collections.Generic.Dictionary<System.Int32,DB.AttributeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE_IDX_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , System.String> get_AttributeIdxIdDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeIdxIdDict", "System.Collections.Generic.Dictionary<System.Int32,System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE_IDX_ID_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData> get_BattleAttributeIdxDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleAttributeIdxDict", "System.Collections.Generic.Dictionary<System.Int32,DB.BattleAttributeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_ATTRIBUTE_IDX_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>> get_BattleRoleSkillDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleRoleSkillDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.BattleSkillData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_ROLE_SKILL_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>> get_BattleSkillLvDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleSkillLvDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,DB.BattleSkillLevelData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_SKILL_LV_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData> get_CalendarIndexDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CalendarIndexDict", "System.Collections.Generic.Dictionary<System.Int32,DB.CalendarData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CALENDAR_INDEX_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String> get_DayRolePointDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DayRolePointDict", "System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey,System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DAY_ROLE_POINT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>> get_ItemDataListDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemDataListDict", "System.Collections.Generic.Dictionary<CYLProject.ItemType,System.Collections.Generic.List<DB.ItemData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_DATA_LIST_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , System.Int32> get_LevelExpDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LevelExpDict", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LEVEL_EXP_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> get_MapOneEventDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MapOneEventDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_ONE_EVENT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> get_MapTwoEventDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MapTwoEventDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_TWO_EVENT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>> get_RoleAttributeDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoleAttributeDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleAttributeData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ROLE_ATTRIBUTE_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>> get_RoleBattleTalentDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoleBattleTalentDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleTalentData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ROLE_BATTLE_TALENT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> get_RoleMapEventDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoleMapEventDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ROLE_MAP_EVENT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>> get_ShopLevelDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShopLevelDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<DB.ShopLevelData>>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SHOP_LEVEL_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>> get_StudyCateDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyCateDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.StudyData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STUDY_CATE_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>> get_VisitDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_VisitDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.ScheduleVisitData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_VISIT_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.ValueTuple<System.String , System.Int32>> GetBattleAllEnemys(System.String battleId)
            /// </summary>
            /// <param name = "battleId">class System.String</param>
            /// <returns>class System.Collections.Generic.List<System.ValueTuple<System.String , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleAllEnemys", "System.Collections.Generic.List<System.ValueTuple<System.String,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_BATTLE_ALL_ENEMYS(nint battleId); 
*/
            /// <summary>
            ///   System.String GetBattleConsumeDescription(System.String saveId)
            /// </summary>
            /// <param name = "saveId">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleConsumeDescription", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_BATTLE_CONSUME_DESCRIPTION(nint saveId); 
*/
            /// <summary>
            ///   DB.CalendarData GetCalendarData(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class DB.CalendarData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCalendarData", "DB.CalendarData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_CALENDAR_DATA(System.Int32 index); 
*/
            /// <summary>
            ///   DB.CalendarData GetCalendarData(System.Int32 startIndex, System.Int32 endIndex, System.Int32 duraton)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "endIndex">struct System.Int32</param>
            /// <param name = "duraton">struct System.Int32</param>
            /// <returns>class DB.CalendarData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCalendarData", "DB.CalendarData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint GET_CALENDAR_DATA(System.Int32 startIndex, System.Int32 endIndex, System.Int32 duraton); 
*/
            /// <summary>
            ///   System.String GetDayRolePoint(System.Int32 dayIdx, System.String roleId)
            /// </summary>
            /// <param name = "dayIdx">struct System.Int32</param>
            /// <param name = "roleId">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDayRolePoint", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial nint GET_DAY_ROLE_POINT(System.Int32 dayIdx, nint roleId); 
*/
            /// <summary>
            ///   System.Single[] GetEnemyAttributeValues(System.String battleRoleId, System.Int32 level)
            /// </summary>
            /// <param name = "battleRoleId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnemyAttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ENEMY_ATTRIBUTE_VALUES(nint battleRoleId, System.Int32 level); 
*/
            /// <summary>
            ///   System.Single[] GetEnemyBattleAttributeValues(System.String enemyId, System.Int32 level)
            /// </summary>
            /// <param name = "enemyId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnemyBattleAttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ENEMY_BATTLE_ATTRIBUTE_VALUES(nint enemyId, System.Int32 level); 
*/
            /// <summary>
            ///   System.Int32 GetExpCurrCap(System.Int32 level)
            /// </summary>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExpCurrCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_EXP_CURR_CAP(System.Int32 level); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Int32 , System.Int32 , System.String> GetFPDetail(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.ValueTuple<System.Int32 , System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFPDetail", "System.ValueTuple<System.Int32,System.Int32,System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.ValueTuple<System.Int32, System.Int32, System.String> GET_FP_DETAIL(System.Int32 value); 
*/
            /// <summary>
            ///   System.Int32 GetLevel(System.Int32 exp)
            /// </summary>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_LEVEL(System.Int32 exp); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Int32 , System.Int32 , System.Int32> GetLevelCap(System.Int32 exp)
            /// </summary>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.ValueTuple<System.Int32 , System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLevelCap", "System.ValueTuple<System.Int32,System.Int32,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.ValueTuple<System.Int32, System.Int32, System.Int32> GET_LEVEL_CAP(System.Int32 exp); 
*/
            /// <summary>
            ///   System.String GetLockEquipmentEffectName(DB.EquipmentEffectData data)
            /// </summary>
            /// <param name = "data">class DB.EquipmentEffectData</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLockEquipmentEffectName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.EquipmentEffectData", 0)]
            public partial nint GET_LOCK_EQUIPMENT_EFFECT_NAME(nint data); 
*/
            /// <summary>
            ///   System.Int32 GetMaxLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_LEVEL(); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Int32> GetMedicineEffectDescription(System.String id, System.String effectId, System.Boolean showColor)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "effectId">class System.String</param>
            /// <param name = "showColor">struct System.Boolean</param>
            /// <returns>struct System.ValueTuple<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMedicineEffectDescription", "System.ValueTuple<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.ValueTuple<System.String, System.Int32> GET_MEDICINE_EFFECT_DESCRIPTION(nint id, nint effectId, System.Boolean showColor); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Int32> GetMedicineEffectDescription(System.String effectId, System.Boolean showColor, System.Boolean isFormat)
            /// </summary>
            /// <param name = "effectId">class System.String</param>
            /// <param name = "showColor">struct System.Boolean</param>
            /// <param name = "isFormat">struct System.Boolean</param>
            /// <returns>struct System.ValueTuple<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMedicineEffectDescription", "System.ValueTuple<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.ValueTuple<System.String, System.Int32> GET_MEDICINE_EFFECT_DESCRIPTION(nint effectId, System.Boolean showColor, System.Boolean isFormat); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Int32> GetMissileEffectDescription(System.String itemId, System.String effectId, System.Boolean showColor)
            /// </summary>
            /// <param name = "itemId">class System.String</param>
            /// <param name = "effectId">class System.String</param>
            /// <param name = "showColor">struct System.Boolean</param>
            /// <returns>struct System.ValueTuple<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissileEffectDescription", "System.ValueTuple<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.ValueTuple<System.String, System.Int32> GET_MISSILE_EFFECT_DESCRIPTION(nint itemId, nint effectId, System.Boolean showColor); 
*/
            /// <summary>
            ///   System.String GetMissionName(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissionName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MISSION_NAME(System.Int32 missionId); 
*/
            /// <summary>
            ///   System.String GetMissionName(DB.ConditionData missionData)
            /// </summary>
            /// <param name = "missionData">class DB.ConditionData</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissionName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.ConditionData", 0)]
            public partial nint GET_MISSION_NAME(nint missionData); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.ValueTuple<System.String , System.Int32>> GetRandomEnemys(System.String poolStr, System.Int32[] levelRange, System.Int32[] cntRange)
            /// </summary>
            /// <param name = "poolStr">class System.String</param>
            /// <param name = "levelRange">class System.Int32[]</param>
            /// <param name = "cntRange">class System.Int32[]</param>
            /// <returns>class System.Collections.Generic.List<System.ValueTuple<System.String , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomEnemys", "System.Collections.Generic.List<System.ValueTuple<System.String,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 2)]
            public partial nint GET_RANDOM_ENEMYS(nint poolStr, nint levelRange, nint cntRange); 
*/
            /// <summary>
            ///   System.String GetRoleName(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ROLE_NAME(nint id); 
*/
            /// <summary>
            ///   System.String GetSpriteLoadPath(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSpriteLoadPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SPRITE_LOAD_PATH(nint path); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Boolean> GetUIWinManual(System.String uiwinName, System.Int32 argInt, System.String argString)
            /// </summary>
            /// <param name = "uiwinName">class System.String</param>
            /// <param name = "argInt">struct System.Int32</param>
            /// <param name = "argString">class System.String</param>
            /// <returns>struct System.ValueTuple<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUIWinManual", "System.ValueTuple<System.String,System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial System.ValueTuple<System.String, System.Boolean> GET_UI_WIN_MANUAL(nint uiwinName, System.Int32 argInt, nint argString); 
*/
            /// <summary>
            ///   System.Void LoadAttributeData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAttributeData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_ATTRIBUTE_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadBattleEnemyData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadBattleEnemyData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_BATTLE_ENEMY_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadCalendarData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadCalendarData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_CALENDAR_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadItemDataList()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadItemDataList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_ITEM_DATA_LIST(); 
*/
            /// <summary>
            ///   System.Void LoadLevelExpData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadLevelExpData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_LEVEL_EXP_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadMapEventData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadMapEventData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_MAP_EVENT_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadRoleTalent()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRoleTalent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_ROLE_TALENT(); 
*/
            /// <summary>
            ///   System.Void LoadSchedule()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSchedule", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_SCHEDULE(); 
*/
            /// <summary>
            ///   System.Void LoadShopData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadShopData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_SHOP_DATA(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask LoadSpriteLoadPath()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSpriteLoadPath", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask LOAD_SPRITE_LOAD_PATH(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask OnInitAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask ON_INIT_ASYNC(); 
*/
            /// <summary>
            ///   System.Void set_AttributeIdxDict(System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.Int32 , DB.AttributeData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeIdxDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,DB.AttributeData>", 0)]
            public partial void SET_ATTRIBUTE_IDX_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_AttributeIdxIdDict(System.Collections.Generic.Dictionary<System.Int32 , System.String> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.Int32 , System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeIdxIdDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,System.String>", 0)]
            public partial void SET_ATTRIBUTE_IDX_ID_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_BattleAttributeIdxDict(System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.Int32 , DB.BattleAttributeData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleAttributeIdxDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,DB.BattleAttributeData>", 0)]
            public partial void SET_BATTLE_ATTRIBUTE_IDX_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_BattleRoleSkillDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.BattleSkillData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleRoleSkillDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.BattleSkillData>>", 0)]
            public partial void SET_BATTLE_ROLE_SKILL_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_BattleSkillLvDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillLevelData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleSkillLvDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,DB.BattleSkillLevelData>>", 0)]
            public partial void SET_BATTLE_SKILL_LV_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_CalendarIndexDict(System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.Int32 , DB.CalendarData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CalendarIndexDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,DB.CalendarData>", 0)]
            public partial void SET_CALENDAR_INDEX_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_DayRolePointDict(System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey , System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DayRolePointDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<CYLProject.GameDataManager.DayRoleKey,System.String>", 0)]
            public partial void SET_DAY_ROLE_POINT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_ItemDataListDict(System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<CYLProject.ItemType , System.Collections.Generic.List<DB.ItemData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ItemDataListDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<CYLProject.ItemType,System.Collections.Generic.List<DB.ItemData>>", 0)]
            public partial void SET_ITEM_DATA_LIST_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_LevelExpDict(System.Collections.Generic.Dictionary<System.Int32 , System.Int32> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LevelExpDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,System.Int32>", 0)]
            public partial void SET_LEVEL_EXP_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_MapOneEventDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MapOneEventDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", 0)]
            public partial void SET_MAP_ONE_EVENT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_MapTwoEventDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MapTwoEventDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", 0)]
            public partial void SET_MAP_TWO_EVENT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_RoleAttributeDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleAttributeData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoleAttributeDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleAttributeData>>", 0)]
            public partial void SET_ROLE_ATTRIBUTE_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_RoleBattleTalentDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.RoleTalentData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoleBattleTalentDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.RoleTalentData>>", 0)]
            public partial void SET_ROLE_BATTLE_TALENT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_RoleMapEventDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.MapEventData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoleMapEventDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.MapEventData>>", 0)]
            public partial void SET_ROLE_MAP_EVENT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_ShopLevelDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.Dictionary<System.Int32 , System.Collections.Generic.List<DB.ShopLevelData>>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ShopLevelDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<DB.ShopLevelData>>>", 0)]
            public partial void SET_SHOP_LEVEL_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_StudyCateDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.StudyData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyCateDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.StudyData>>", 0)]
            public partial void SET_STUDY_CATE_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void set_VisitDict(System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<DB.ScheduleVisitData>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_VisitDict", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<DB.ScheduleVisitData>>", 0)]
            public partial void SET_VISIT_DICT(nint value); 
*/
            /// <summary>
            ///   System.Void ShowRewardTip(System.String rewardId, System.Int32 count)
            /// </summary>
            /// <param name = "rewardId">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowRewardTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SHOW_REWARD_TIP(nint rewardId, System.Int32 count); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_GameDataManager
        {
            /// <summary>
            /// static  CYLProject.GameDataManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.GameDataManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.GameDataManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INSTANCE(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void CUpdate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void C_UPDATE(); 
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
            ///   System.Boolean get_InitCompleted()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InitCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_INIT_COMPLETED(); 
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
            ///   Cysharp.Threading.Tasks.UniTask InitAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask INIT_ASYNC(); 
*/
            /// <summary>
            ///   System.Void OnDispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DISPOSE(); 
*/
            /// <summary>
            ///   System.Void OnInit()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INIT(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask OnInitAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask ON_INIT_ASYNC(); 
*/
            /// <summary>
            ///   System.Void OnUpdate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_UPDATE(); 
*/
            /// <summary>
            ///   System.Void set_InitCompleted(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_InitCompleted", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_INIT_COMPLETED(System.Boolean value); 
*/
        }
    }
}
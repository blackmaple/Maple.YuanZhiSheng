namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."GameBuffManager"]
    /// [BaseManager<CYLProject.GameBuffManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameBuffManager>, Ptr_GameBuffManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "GameBuffManager", "CYLProject.GameBuffManager")]
    public partial class GameBuffManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameBuffManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameBuffManager(System.IntPtr ptr) => new Ptr_GameBuffManager(ptr);
            public static implicit operator System.IntPtr(Ptr_GameBuffManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GameBuffManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameBuffManager"]
        /// </summary>
        partial struct Ptr_GameBuffManager
        {
            /// <summary>
            /// 0x0 CYLProject.GameBuffManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameBuffManager"]
            /// </summary>
            /// <returns>class CYLProject.GameBuffManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.GameBuffManager")]
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
            /// 0x18 System.Text.StringBuilder _strbd
            /// class ["mscorlib.dll"."System.Text"."StringBuilder"]
            /// </summary>
            /// <returns>class System.Text.StringBuilder</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_strbd", "System.Text.StringBuilder")]
            public partial nint _STRBD { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.EBuffArgTypeData>> _argTypsDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.EBuffArgTypeData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_argTypsDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<CYLProject.EBuffArgTypeData>>")]
            public partial nint _ARG_TYPS_DICT { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Collections.Generic.List<CYLProject.BuffArg>>> _argsListDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<System.Collections.Generic.List<CYLProject.BuffArg>>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_argsListDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Collections.Generic.List<CYLProject.BuffArg>>>")]
            public partial nint _ARGS_LIST_DICT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , CYLProject.EBuffEffectData> _buffEffectEnumDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.EBuffEffectData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_buffEffectEnumDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.EBuffEffectData>")]
            public partial nint _BUFF_EFFECT_ENUM_DICT { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<CYLProject.AttributeType , System.Single [ ]> _tempDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.AttributeType , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_tempDict", "System.Collections.Generic.Dictionary<CYLProject.AttributeType,System.Single[]>")]
            public partial nint _TEMP_DICT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameBuffManager"]
        /// </summary>
        partial struct Ptr_GameBuffManager
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
            ///   System.Void BAttriDictAdd(System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]> dict, CYLProject.BattleAttributeType type, System.Single value, System.Single percent)
            /// </summary>
            /// <param name = "dict">class System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]></param>
            /// <param name = "type">enum CYLProject.BattleAttributeType</param>
            /// <param name = "value">struct System.Single</param>
            /// <param name = "percent">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BAttriDictAdd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType,System.Single[]>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BattleAttributeType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void B_ATTRI_DICT_ADD(nint dict, CYLProject.BattleAttributeType type, System.Single value, System.Single percent); 
*/
            /// <summary>
            ///   System.String BuffDesc(System.String buffId, System.Int32 level, System.Boolean showAllLevel)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "showAllLevel">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BuffDesc", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint BUFF_DESC(nint buffId, System.Int32 level, System.Boolean showAllLevel); 
*/
            /// <summary>
            ///   System.String GetArgValue(CYLProject.EBuffArgTypeData argType, CYLProject.BuffArg arg)
            /// </summary>
            /// <param name = "argType">enum CYLProject.EBuffArgTypeData</param>
            /// <param name = "arg">struct CYLProject.BuffArg</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArgValue", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.EBuffArgTypeData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BuffArg", 1)]
            public partial nint GET_ARG_VALUE(CYLProject.EBuffArgTypeData argType, CYLProject.BuffArg arg); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.AttributeType , System.Single [ ]> GetAttributeAdd(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.AttributeType , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeAdd", "System.Collections.Generic.Dictionary<CYLProject.AttributeType,System.Single[]>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            public partial nint GET_ATTRIBUTE_ADD(nint buffDict); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]> GetBaseBattleAttributeAdd(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseBattleAttributeAdd", "System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType,System.Single[]>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            public partial nint GET_BASE_BATTLE_ATTRIBUTE_ADD(nint buffDict); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]> GetBattleAttributeAdd(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleAttributeAdd", "System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType,System.Single[]>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            public partial nint GET_BATTLE_ATTRIBUTE_ADD(nint buffDict); 
*/
            /// <summary>
            ///   CYLProject.BattleBuffVisiblePlace GetBattleBuffVisiblePlace(CYLProject.EBuffEffectData type)
            /// </summary>
            /// <param name = "type">enum CYLProject.EBuffEffectData</param>
            /// <returns>enum CYLProject.BattleBuffVisiblePlace</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleBuffVisiblePlace", "CYLProject.BattleBuffVisiblePlace", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.EBuffEffectData", 0)]
            public partial CYLProject.BattleBuffVisiblePlace GET_BATTLE_BUFF_VISIBLE_PLACE(CYLProject.EBuffEffectData type); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<CYLProject.BuffArg> GetBuffArgs(System.String buffId, System.Int32 level)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<CYLProject.BuffArg></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuffArgs", "System.Collections.Generic.List<CYLProject.BuffArg>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_BUFF_ARGS(nint buffId, System.Int32 level); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Int32> GetBuffDescription(System.String buffId, System.Int32 level, System.Boolean showName, System.Boolean allLevel, System.Boolean showColor)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "showName">struct System.Boolean</param>
            /// <param name = "allLevel">struct System.Boolean</param>
            /// <param name = "showColor">struct System.Boolean</param>
            /// <returns>struct System.ValueTuple<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuffDescription", "System.ValueTuple<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial System.ValueTuple<System.String, System.Int32> GET_BUFF_DESCRIPTION(nint buffId, System.Int32 level, System.Boolean showName, System.Boolean allLevel, System.Boolean showColor); 
*/
            /// <summary>
            ///   System.Boolean GetBuffIsType(System.String buffId, CYLProject.BuffType buffType)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "buffType">enum CYLProject.BuffType</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuffIsType", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BuffType", 1)]
            public partial System.Boolean GET_BUFF_IS_TYPE(nint buffId, CYLProject.BuffType buffType); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Int32 , System.Int32> GetBuffLayerCapDuration(System.String buffId, System.Int32 level)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.ValueTuple<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuffLayerCapDuration", "System.ValueTuple<System.Int32,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.ValueTuple<System.Int32, System.Int32> GET_BUFF_LAYER_CAP_DURATION(nint buffId, System.Int32 level); 
*/
            /// <summary>
            ///   System.String GetBuffSimpleDesc(System.String buffId, System.Int32 level)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuffSimpleDesc", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_BUFF_SIMPLE_DESC(nint buffId, System.Int32 level); 
*/
            /// <summary>
            ///   System.Single GetCreateProduceGoldDiscount(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict, System.String itemId)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <param name = "itemId">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCreateProduceGoldDiscount", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Single GET_CREATE_PRODUCE_GOLD_DISCOUNT(nint buffDict, nint itemId); 
*/
            /// <summary>
            ///   CYLProject.EBuffEffectData GetEnum(System.String buffEffectId)
            /// </summary>
            /// <param name = "buffEffectId">class System.String</param>
            /// <returns>enum CYLProject.EBuffEffectData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnum", "CYLProject.EBuffEffectData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial CYLProject.EBuffEffectData GET_ENUM(nint buffEffectId); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Single> GetEquipmentBattleAttributeAdd(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipmentBattleAttributeAdd", "System.Collections.Generic.Dictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            public partial nint GET_EQUIPMENT_BATTLE_ATTRIBUTE_ADD(nint buffDict); 
*/
            /// <summary>
            ///   System.Single LittleGameDoubleMatRatio(CYLProject.LittleGameType type, System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "type">enum CYLProject.LittleGameType</param>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LittleGameDoubleMatRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.LittleGameType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 1)]
            public partial System.Single LITTLE_GAME_DOUBLE_MAT_RATIO(CYLProject.LittleGameType type, nint buffDict); 
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
            ///   System.Single SecretRealmDoubleRewardRatio(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SecretRealmDoubleRewardRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            public partial System.Single SECRET_REALM_DOUBLE_REWARD_RATIO(nint buffDict); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_GameBuffManager
        {
            /// <summary>
            /// static  CYLProject.GameBuffManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.GameBuffManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.GameBuffManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
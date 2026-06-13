namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."BattleSkillLevelData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BattleSkillLevelData>, Ptr_BattleSkillLevelData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "BattleSkillLevelData", "DB.BattleSkillLevelData")]
    public partial class BattleSkillLevelData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BattleSkillLevelData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BattleSkillLevelData(System.IntPtr ptr) => new Ptr_BattleSkillLevelData(ptr);
            public static implicit operator System.IntPtr(Ptr_BattleSkillLevelData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BattleSkillLevelData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."BattleSkillLevelData"]
        /// </summary>
        partial struct Ptr_BattleSkillLevelData
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.List<DB.BattleSkillLevelData> list
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.BattleSkillLevelData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("list", "System.Collections.Generic.List<DB.BattleSkillLevelData>")]
            public static partial nint LIST { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.Dictionary<System.String , DB.BattleSkillLevelData> map
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , DB.BattleSkillLevelData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("map", "System.Collections.Generic.Dictionary<System.String,DB.BattleSkillLevelData>")]
            public static partial nint MAP { get; set; } 
*/

            /// <summary>
            /// 0x10 System.String <id>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<id>k__BackingField", "System.String")]
            public partial nint ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String <SkillId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SkillId>k__BackingField", "System.String")]
            public partial nint SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 <Level>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Level>k__BackingField", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 <Cost>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Cost>k__BackingField", "System.Int32")]
            public partial System.Int32 COST { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single <AdditionPercent>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AdditionPercent>k__BackingField", "System.Single")]
            public partial System.Single ADDITION_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String <Ranges>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Ranges>k__BackingField", "System.String")]
            public partial nint RANGES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] <ValueTypes>k__BackingField
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ValueTypes>k__BackingField", "System.Int32[]")]
            public partial nint VALUE_TYPES { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32[] <TargetEffects>k__BackingField
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TargetEffects>k__BackingField", "System.Int32[]")]
            public partial nint TARGET_EFFECTS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Single[] <BaseValues>k__BackingField
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BaseValues>k__BackingField", "System.Single[]")]
            public partial nint BASE_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String <BAttributes>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BAttributes>k__BackingField", "System.String")]
            public partial nint B_ATTRIBUTES { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single[] <BAttributeRates>k__BackingField
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BAttributeRates>k__BackingField", "System.Single[]")]
            public partial nint B_ATTRIBUTE_RATES { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String <SelfBuffs>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SelfBuffs>k__BackingField", "System.String")]
            public partial nint SELF_BUFFS { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String <TargetBuffs>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TargetBuffs>k__BackingField", "System.String")]
            public partial nint TARGET_BUFFS { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String <AnimId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AnimId>k__BackingField", "System.String")]
            public partial nint ANIM_ID { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String <QTEAnimId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<QTEAnimId>k__BackingField", "System.String")]
            public partial nint QTE_ANIM_ID { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String <QTEs>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<QTEs>k__BackingField", "System.String")]
            public partial nint QT_ES { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 <QTECost>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<QTECost>k__BackingField", "System.Int32")]
            public partial System.Int32 QTE_COST { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."BattleSkillLevelData"]
        /// </summary>
        partial struct Ptr_BattleSkillLevelData
        {
            /// <summary>
            /// static  System.Void _Load(System.String json)
            /// </summary>
            /// <param name = "json">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("_Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void _LOAD(nint json); 
*/
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  DB.BattleSkillLevelData Get(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>class DB.BattleSkillLevelData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DB.BattleSkillLevelData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint GET(nint id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<DB.BattleSkillLevelData> GetAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.BattleSkillLevelData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAll", "System.Collections.Generic.List<DB.BattleSkillLevelData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ALL(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillLevelData>> GetAllAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillLevelData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllAsync", "Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillLevelData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillLevelData>> GET_ALL_ASYNC(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<DB.BattleSkillLevelData> GetAsync(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<DB.BattleSkillLevelData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAsync", "Cysharp.Threading.Tasks.UniTask<DB.BattleSkillLevelData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial Cysharp.Threading.Tasks.UniTask<DB.BattleSkillLevelData> GET_ASYNC(nint id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Void Load()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void LOAD(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask LoadAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask LOAD_ASYNC(); 
*/
            /// <summary>
            /// static  System.Void Unload()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unload", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void UNLOAD(); 
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
            ///   System.Single get_AdditionPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AdditionPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_ADDITION_PERCENT(); 
*/
            /// <summary>
            ///   System.String get_AnimId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AnimId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ANIM_ID(); 
*/
            /// <summary>
            ///   System.Single[] get_BaseValues()
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BaseValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BASE_VALUES(); 
*/
            /// <summary>
            ///   System.Single[] get_BAttributeRates()
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BAttributeRates", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_B_ATTRIBUTE_RATES(); 
*/
            /// <summary>
            ///   System.String get_BAttributes()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BAttributes", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_B_ATTRIBUTES(); 
*/
            /// <summary>
            ///   System.Int32 get_Cost()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Cost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COST(); 
*/
            /// <summary>
            ///   System.String get_id()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_id", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_Level()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Level", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LEVEL(); 
*/
            /// <summary>
            ///   System.String get_QTEAnimId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_QTEAnimId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_QTE_ANIM_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_QTECost()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_QTECost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_QTE_COST(); 
*/
            /// <summary>
            ///   System.String get_QTEs()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_QTEs", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_QT_ES(); 
*/
            /// <summary>
            ///   System.String get_Ranges()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Ranges", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RANGES(); 
*/
            /// <summary>
            ///   System.String get_SelfBuffs()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SelfBuffs", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SELF_BUFFS(); 
*/
            /// <summary>
            ///   System.String get_SkillId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_ID(); 
*/
            /// <summary>
            ///   System.String get_TargetBuffs()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TargetBuffs", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TARGET_BUFFS(); 
*/
            /// <summary>
            ///   System.Int32[] get_TargetEffects()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TargetEffects", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TARGET_EFFECTS(); 
*/
            /// <summary>
            ///   System.Int32[] get_ValueTypes()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ValueTypes", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_VALUE_TYPES(); 
*/
            /// <summary>
            ///   System.Void set_AdditionPercent(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AdditionPercent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_ADDITION_PERCENT(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_AnimId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AnimId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ANIM_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_BaseValues(System.Single[] value)
            /// </summary>
            /// <param name = "value">class System.Single[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BaseValues", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 0)]
            public partial void SET_BASE_VALUES(nint value); 
*/
            /// <summary>
            ///   System.Void set_BAttributeRates(System.Single[] value)
            /// </summary>
            /// <param name = "value">class System.Single[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BAttributeRates", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 0)]
            public partial void SET_B_ATTRIBUTE_RATES(nint value); 
*/
            /// <summary>
            ///   System.Void set_BAttributes(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BAttributes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_B_ATTRIBUTES(nint value); 
*/
            /// <summary>
            ///   System.Void set_Cost(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Cost", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_COST(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_id(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_Level(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Level", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_LEVEL(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_QTEAnimId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_QTEAnimId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_QTE_ANIM_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_QTECost(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_QTECost", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_QTE_COST(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_QTEs(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_QTEs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_QT_ES(nint value); 
*/
            /// <summary>
            ///   System.Void set_Ranges(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Ranges", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_RANGES(nint value); 
*/
            /// <summary>
            ///   System.Void set_SelfBuffs(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SelfBuffs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_SELF_BUFFS(nint value); 
*/
            /// <summary>
            ///   System.Void set_SkillId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SkillId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_SKILL_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_TargetBuffs(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TargetBuffs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_TARGET_BUFFS(nint value); 
*/
            /// <summary>
            ///   System.Void set_TargetEffects(System.Int32[] value)
            /// </summary>
            /// <param name = "value">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TargetEffects", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial void SET_TARGET_EFFECTS(nint value); 
*/
            /// <summary>
            ///   System.Void set_ValueTypes(System.Int32[] value)
            /// </summary>
            /// <param name = "value">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ValueTypes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial void SET_VALUE_TYPES(nint value); 
*/
        }
    }
}
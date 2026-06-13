namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."BattleSkillCategoryData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BattleSkillCategoryData>, Ptr_BattleSkillCategoryData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "BattleSkillCategoryData", "DB.BattleSkillCategoryData")]
    public partial class BattleSkillCategoryData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BattleSkillCategoryData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BattleSkillCategoryData(System.IntPtr ptr) => new Ptr_BattleSkillCategoryData(ptr);
            public static implicit operator System.IntPtr(Ptr_BattleSkillCategoryData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BattleSkillCategoryData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."BattleSkillCategoryData"]
        /// </summary>
        partial struct Ptr_BattleSkillCategoryData
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.List<DB.BattleSkillCategoryData> list
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.BattleSkillCategoryData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("list", "System.Collections.Generic.List<DB.BattleSkillCategoryData>")]
            public static partial nint LIST { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillCategoryData> map
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , DB.BattleSkillCategoryData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("map", "System.Collections.Generic.Dictionary<System.Int32,DB.BattleSkillCategoryData>")]
            public static partial nint MAP { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Int32 <id>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<id>k__BackingField", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String <Name>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Name>k__BackingField", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String <Icon>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Icon>k__BackingField", "System.String")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String <Attribute>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Attribute>k__BackingField", "System.String")]
            public partial nint ATTRIBUTE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single <AdditionPercent>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AdditionPercent>k__BackingField", "System.Single")]
            public partial System.Single ADDITION_PERCENT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."BattleSkillCategoryData"]
        /// </summary>
        partial struct Ptr_BattleSkillCategoryData
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
            /// static  DB.BattleSkillCategoryData Get(System.Int32 id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>class DB.BattleSkillCategoryData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DB.BattleSkillCategoryData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint GET(System.Int32 id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<DB.BattleSkillCategoryData> GetAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.BattleSkillCategoryData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAll", "System.Collections.Generic.List<DB.BattleSkillCategoryData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ALL(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillCategoryData>> GetAllAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillCategoryData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllAsync", "Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillCategoryData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.BattleSkillCategoryData>> GET_ALL_ASYNC(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<DB.BattleSkillCategoryData> GetAsync(System.Int32 id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<DB.BattleSkillCategoryData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAsync", "Cysharp.Threading.Tasks.UniTask<DB.BattleSkillCategoryData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial Cysharp.Threading.Tasks.UniTask<DB.BattleSkillCategoryData> GET_ASYNC(System.Int32 id, System.Boolean showError); 
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
            ///   System.String get_Attribute()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Attribute", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE(); 
*/
            /// <summary>
            ///   System.String get_Icon()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Icon", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ICON(); 
*/
            /// <summary>
            ///   System.Int32 get_id()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_id", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ID(); 
*/
            /// <summary>
            ///   System.String get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
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
            ///   System.Void set_Attribute(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Attribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ATTRIBUTE(nint value); 
*/
            /// <summary>
            ///   System.Void set_Icon(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Icon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ICON(nint value); 
*/
            /// <summary>
            ///   System.Void set_id(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
        }
    }
}
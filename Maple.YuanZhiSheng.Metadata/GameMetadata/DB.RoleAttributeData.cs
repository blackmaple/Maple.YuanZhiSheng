namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."RoleAttributeData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RoleAttributeData>, Ptr_RoleAttributeData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "RoleAttributeData", "DB.RoleAttributeData")]
    public partial class RoleAttributeData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RoleAttributeData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RoleAttributeData(System.IntPtr ptr) => new Ptr_RoleAttributeData(ptr);
            public static implicit operator System.IntPtr(Ptr_RoleAttributeData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_RoleAttributeData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."RoleAttributeData"]
        /// </summary>
        partial struct Ptr_RoleAttributeData
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.List<DB.RoleAttributeData> list
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.RoleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("list", "System.Collections.Generic.List<DB.RoleAttributeData>")]
            public static partial nint LIST { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.Dictionary<System.String , DB.RoleAttributeData> map
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , DB.RoleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("map", "System.Collections.Generic.Dictionary<System.String,DB.RoleAttributeData>")]
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
            /// 0x18 System.Int32 <Level>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Level>k__BackingField", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single[] <Attributes>k__BackingField
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Attributes>k__BackingField", "System.Single[]")]
            public partial nint ATTRIBUTES { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."RoleAttributeData"]
        /// </summary>
        partial struct Ptr_RoleAttributeData
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
            /// static  DB.RoleAttributeData Get(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>class DB.RoleAttributeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DB.RoleAttributeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint GET(nint id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<DB.RoleAttributeData> GetAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.RoleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAll", "System.Collections.Generic.List<DB.RoleAttributeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ALL(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleAttributeData>> GetAllAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleAttributeData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllAsync", "Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleAttributeData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleAttributeData>> GET_ALL_ASYNC(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<DB.RoleAttributeData> GetAsync(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<DB.RoleAttributeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAsync", "Cysharp.Threading.Tasks.UniTask<DB.RoleAttributeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial Cysharp.Threading.Tasks.UniTask<DB.RoleAttributeData> GET_ASYNC(nint id, System.Boolean showError); 
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
            ///   System.Single[] get_Attributes()
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Attributes", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTES(); 
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
            ///   System.Void set_Attributes(System.Single[] value)
            /// </summary>
            /// <param name = "value">class System.Single[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Attributes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 0)]
            public partial void SET_ATTRIBUTES(nint value); 
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
        }
    }
}
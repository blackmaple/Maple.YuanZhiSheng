namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."RoleTalentData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RoleTalentData>, Ptr_RoleTalentData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "RoleTalentData", "DB.RoleTalentData")]
    public partial class RoleTalentData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RoleTalentData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RoleTalentData(System.IntPtr ptr) => new Ptr_RoleTalentData(ptr);
            public static implicit operator System.IntPtr(Ptr_RoleTalentData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_RoleTalentData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."RoleTalentData"]
        /// </summary>
        partial struct Ptr_RoleTalentData
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.List<DB.RoleTalentData> list
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.RoleTalentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("list", "System.Collections.Generic.List<DB.RoleTalentData>")]
            public static partial nint LIST { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.Dictionary<System.String , DB.RoleTalentData> map
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , DB.RoleTalentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("map", "System.Collections.Generic.Dictionary<System.String,DB.RoleTalentData>")]
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
            /// 0x18 System.String <Name>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Name>k__BackingField", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String <Description>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Description>k__BackingField", "System.String")]
            public partial nint DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32[] <Conditions>k__BackingField
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Conditions>k__BackingField", "System.Int32[]")]
            public partial nint CONDITIONS { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String <Icon>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Icon>k__BackingField", "System.String")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String <OwnerRoleId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OwnerRoleId>k__BackingField", "System.String")]
            public partial nint OWNER_ROLE_ID { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 <Row>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Row>k__BackingField", "System.Int32")]
            public partial System.Int32 ROW { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 <PointCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PointCap>k__BackingField", "System.Int32")]
            public partial System.Int32 POINT_CAP { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String <TargetSkill>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TargetSkill>k__BackingField", "System.String")]
            public partial nint TARGET_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String <TargetBuff>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TargetBuff>k__BackingField", "System.String")]
            public partial nint TARGET_BUFF { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."RoleTalentData"]
        /// </summary>
        partial struct Ptr_RoleTalentData
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
            /// static  DB.RoleTalentData Get(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>class DB.RoleTalentData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DB.RoleTalentData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint GET(nint id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<DB.RoleTalentData> GetAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.RoleTalentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAll", "System.Collections.Generic.List<DB.RoleTalentData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ALL(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleTalentData>> GetAllAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleTalentData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllAsync", "Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleTalentData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.RoleTalentData>> GET_ALL_ASYNC(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<DB.RoleTalentData> GetAsync(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<DB.RoleTalentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAsync", "Cysharp.Threading.Tasks.UniTask<DB.RoleTalentData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial Cysharp.Threading.Tasks.UniTask<DB.RoleTalentData> GET_ASYNC(nint id, System.Boolean showError); 
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
            ///   System.Int32[] get_Conditions()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Conditions", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONDITIONS(); 
*/
            /// <summary>
            ///   System.String get_Description()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Description", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESCRIPTION(); 
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
            ///   System.String get_id()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_id", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ID(); 
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
            ///   System.String get_OwnerRoleId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OwnerRoleId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OWNER_ROLE_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_PointCap()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PointCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_POINT_CAP(); 
*/
            /// <summary>
            ///   System.Int32 get_Row()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Row", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ROW(); 
*/
            /// <summary>
            ///   System.String get_TargetBuff()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TargetBuff", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TARGET_BUFF(); 
*/
            /// <summary>
            ///   System.String get_TargetSkill()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TargetSkill", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TARGET_SKILL(); 
*/
            /// <summary>
            ///   System.Void set_Conditions(System.Int32[] value)
            /// </summary>
            /// <param name = "value">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Conditions", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial void SET_CONDITIONS(nint value); 
*/
            /// <summary>
            ///   System.Void set_Description(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Description", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_DESCRIPTION(nint value); 
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
            ///   System.Void set_Name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.Void set_OwnerRoleId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OwnerRoleId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_OWNER_ROLE_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_PointCap(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PointCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_POINT_CAP(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Row(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Row", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ROW(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_TargetBuff(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TargetBuff", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_TARGET_BUFF(nint value); 
*/
            /// <summary>
            ///   System.Void set_TargetSkill(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TargetSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_TARGET_SKILL(nint value); 
*/
        }
    }
}
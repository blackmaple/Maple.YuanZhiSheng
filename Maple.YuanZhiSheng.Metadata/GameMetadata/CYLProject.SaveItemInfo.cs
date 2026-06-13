namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."SaveItemInfo"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SaveItemInfo>, Ptr_SaveItemInfo>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "SaveItemInfo", "CYLProject.SaveItemInfo")]
    public partial class SaveItemInfo
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SaveItemInfo(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SaveItemInfo(System.IntPtr ptr) => new Ptr_SaveItemInfo(ptr);
            public static implicit operator System.IntPtr(Ptr_SaveItemInfo ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SaveItemInfo ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."SaveItemInfo"]
        /// </summary>
        partial struct Ptr_SaveItemInfo
        {
            /// <summary>
            /// 0x10 System.String SaveId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SaveId", "System.String")]
            public partial nint SAVE_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String ItemId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ItemId", "System.String")]
            public partial nint ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> EffectIds
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectIds", "System.Collections.Generic.List<System.String>")]
            public partial nint EFFECT_IDS { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.Single> EffectValues
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectValues", "System.Collections.Generic.List<System.Single>")]
            public partial nint EFFECT_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<System.Int32> EffectFroms
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectFroms", "System.Collections.Generic.List<System.Int32>")]
            public partial nint EFFECT_FROMS { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.String> Buffs
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Buffs", "System.Collections.Generic.List<System.String>")]
            public partial nint BUFFS { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<System.Int32> BuffFroms
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuffFroms", "System.Collections.Generic.List<System.Int32>")]
            public partial nint BUFF_FROMS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String RoleId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RoleId", "System.String")]
            public partial nint ROLE_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."SaveItemInfo"]
        /// </summary>
        partial struct Ptr_SaveItemInfo
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}
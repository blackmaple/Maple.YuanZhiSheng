namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_UniTaskGeneric>, Ptr_UniTaskGeneric>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UniTask.dll", "Cysharp.Threading.Tasks", "UniTask`1", "Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>")]
    public partial class UniTaskGeneric
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_UniTaskGeneric
        {
            /// <summary>
            /// 0x0 Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite> source
            /// interface ["UniTask.dll"."Cysharp.Threading.Tasks"."IUniTaskSource`1"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public nint source;
            /// <summary>
            /// 0x8 UnityEngine.Sprite result
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public nint result;
            /// <summary>
            /// 0x10 System.Int16 token
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public System.Int16 token;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_UniTaskGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_UniTaskGeneric(System.IntPtr ptr) => new Ptr_UniTaskGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_UniTaskGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_UniTaskGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
        /// </summary>
        partial struct Ptr_UniTaskGeneric
        {
            /// <summary>
            /// 0x10 Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite> source
            /// interface ["UniTask.dll"."Cysharp.Threading.Tasks"."IUniTaskSource`1"]
            /// </summary>
            /// <returns>interface Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("source", "Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite>")]
            public partial nint SOURCE { get; set; } 
*/

            /// <summary>
            /// 0x18 UnityEngine.Sprite result
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("result", "UnityEngine.Sprite")]
            public partial nint RESULT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int16 token
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("token", "System.Int16")]
            public partial System.Int16 TOKEN { get; set; } 
*/
        }

        /// <summary>
        /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask`1"]
        /// </summary>
        partial struct Ptr_UniTaskGeneric
        {
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask op_Implicit(Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> self)
            /// </summary>
            /// <param name = "self">struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite></param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>", 0)]
            public static partial Cysharp.Threading.Tasks.UniTask OP_IMPLICIT(Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> self); 
*/
            /// <summary>
            /// static  System.Threading.Tasks.ValueTask<UnityEngine.Sprite> op_Implicit(Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>& self)
            /// </summary>
            /// <param name = "self">struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>&</param>
            /// <returns>struct System.Threading.Tasks.ValueTask<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "System.Threading.Tasks.ValueTask<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>&", 0)]
            public static partial System.Threading.Tasks.ValueTask<UnityEngine.Sprite> OP_IMPLICIT(Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> &self); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.Sprite result)
            /// </summary>
            /// <param name = "result">class UnityEngine.Sprite</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 0)]
            public partial void CTOR(nint result); 
*/
            /// <summary>
            ///   System.Void .ctor(Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite> source, System.Int16 token)
            /// </summary>
            /// <param name = "source">interface Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite></param>
            /// <param name = "token">struct System.Int16</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Sprite>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int16", 1)]
            public partial void CTOR(nint source, System.Int16 token); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask AsUniTask()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AsUniTask", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask AS_UNI_TASK(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskStatus get_Status()
            /// </summary>
            /// <returns>enum Cysharp.Threading.Tasks.UniTaskStatus</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Status", "Cysharp.Threading.Tasks.UniTaskStatus", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTaskStatus GET_STATUS(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> GetAwaiter()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAwaiter", "Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> GET_AWAITER(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> Preserve()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Preserve", "Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> PRESERVE(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Boolean , UnityEngine.Sprite>> SuppressCancellationThrow()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Boolean , UnityEngine.Sprite>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SuppressCancellationThrow", "Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Boolean,UnityEngine.Sprite>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Boolean, UnityEngine.Sprite>> SUPPRESS_CANCELLATION_THROW(); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
        }
    }
}
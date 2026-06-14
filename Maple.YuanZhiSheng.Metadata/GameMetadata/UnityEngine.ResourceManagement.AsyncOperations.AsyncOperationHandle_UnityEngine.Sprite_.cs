namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// struct ["Unity.ResourceManager.dll"."UnityEngine.ResourceManagement.AsyncOperations"."AsyncOperationHandle`1"]
    /// [System.Collections.IEnumerator]=>[System.IEquatable<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AsyncOperationHandleGeneric>, Ptr_AsyncOperationHandleGeneric>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "AsyncOperationHandle`1", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>")]
    public partial class AsyncOperationHandleGeneric
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AsyncOperationHandleGeneric
        {
            /// <summary>
            /// 0x0 UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite> m_InternalOp
            /// abstract class ["Unity.ResourceManager.dll"."UnityEngine.ResourceManagement.AsyncOperations"."AsyncOperationBase`1"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public nint m_InternalOp;
            /// <summary>
            /// 0x8 System.Int32 m_Version
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Int32 m_Version;
            /// <summary>
            /// 0x10 System.String m_LocationName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public nint m_LocationName;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AsyncOperationHandleGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AsyncOperationHandleGeneric(System.IntPtr ptr) => new Ptr_AsyncOperationHandleGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_AsyncOperationHandleGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AsyncOperationHandleGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Unity.ResourceManager.dll"."UnityEngine.ResourceManagement.AsyncOperations"."AsyncOperationHandle`1"]
        /// </summary>
        partial struct Ptr_AsyncOperationHandleGeneric
        {
            /// <summary>
            /// 0x10 UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite> m_InternalOp
            /// abstract class ["Unity.ResourceManager.dll"."UnityEngine.ResourceManagement.AsyncOperations"."AsyncOperationBase`1"]
            /// </summary>
            /// <returns>abstract class UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_InternalOp", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite>")]
            public partial nint M_INTERNAL_OP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 m_Version
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_Version", "System.Int32")]
            public partial System.Int32 M_VERSION { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String m_LocationName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_LocationName", "System.String")]
            public partial nint M_LOCATION_NAME { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Unity.ResourceManager.dll"."UnityEngine.ResourceManagement.AsyncOperations"."AsyncOperationHandle`1"]
        /// </summary>
        partial struct Ptr_AsyncOperationHandleGeneric
        {
            /// <summary>
            /// static  UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op_Implicit(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> obj)
            /// </summary>
            /// <param name = "obj">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite></param>
            /// <returns>struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>", 0)]
            public static partial UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle OP_IMPLICIT(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> obj); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite> op)
            /// </summary>
            /// <param name = "op">abstract class UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite>", 0)]
            public partial void CTOR(nint op); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op)
            /// </summary>
            /// <param name = "op">interface UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation", 0)]
            public partial void CTOR(nint op); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, System.Int32 version)
            /// </summary>
            /// <param name = "op">interface UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation</param>
            /// <param name = "version">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CTOR(nint op, System.Int32 version); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, System.String locationName)
            /// </summary>
            /// <param name = "op">interface UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation</param>
            /// <param name = "locationName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CTOR(nint op, nint locationName); 
*/
            /// <summary>
            ///   System.Void .ctor(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, System.Int32 version, System.String locationName)
            /// </summary>
            /// <param name = "op">interface UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation</param>
            /// <param name = "version">struct System.Int32</param>
            /// <param name = "locationName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void CTOR(nint op, System.Int32 version, nint locationName); 
*/
            /// <summary>
            ///   UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> Acquire()
            /// </summary>
            /// <returns>struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Acquire", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> ACQUIRE(); 
*/
            /// <summary>
            ///   System.Void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add_Completed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>>", 0)]
            public partial void ADD_COMPLETED(nint value); 
*/
            /// <summary>
            ///   System.Void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add_CompletedTypeless", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>", 0)]
            public partial void ADD_COMPLETED_TYPELESS(nint value); 
*/
            /// <summary>
            ///   System.Void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add_Destroyed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>", 0)]
            public partial void ADD_DESTROYED(nint value); 
*/
            /// <summary>
            ///   System.Boolean Equals(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> other)
            /// </summary>
            /// <param name = "other">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>", 0)]
            public partial System.Boolean EQUALS(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite> other); 
*/
            /// <summary>
            ///   System.String get_DebugName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DebugName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEBUG_NAME(); 
*/
            /// <summary>
            ///   UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite> get_InternalOp()
            /// </summary>
            /// <returns>abstract class UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InternalOp", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_INTERNAL_OP(); 
*/
            /// <summary>
            ///   System.Boolean get_IsDone()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsDone", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_DONE(); 
*/
            /// <summary>
            ///   System.String get_LocationName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LocationName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LOCATION_NAME(); 
*/
            /// <summary>
            ///   System.Exception get_OperationException()
            /// </summary>
            /// <returns>class System.Exception</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OperationException", "System.Exception", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OPERATION_EXCEPTION(); 
*/
            /// <summary>
            ///   System.Single get_PercentComplete()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PercentComplete", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_PERCENT_COMPLETE(); 
*/
            /// <summary>
            ///   System.Int32 get_ReferenceCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ReferenceCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_REFERENCE_COUNT(); 
*/
            /// <summary>
            ///   UnityEngine.Sprite get_Result()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Result", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RESULT(); 
*/
            /// <summary>
            ///   UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status()
            /// </summary>
            /// <returns>enum UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Status", "UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus GET_STATUS(); 
*/
            /// <summary>
            ///   System.Threading.Tasks.Task<UnityEngine.Sprite> get_Task()
            /// </summary>
            /// <returns>class System.Threading.Tasks.Task<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Task", "System.Threading.Tasks.Task<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TASK(); 
*/
            /// <summary>
            ///   System.Int32 get_Version()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Version", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_VERSION(); 
*/
            /// <summary>
            ///   System.Void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps)
            /// </summary>
            /// <param name = "deps">class System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDependencies", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>", 0)]
            public partial void GET_DEPENDENCIES(nint deps); 
*/
            /// <summary>
            ///   UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus()
            /// </summary>
            /// <returns>struct UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDownloadStatus", "UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GET_DOWNLOAD_STATUS(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus InternalGetDownloadStatus(System.Collections.Generic.HashSet<System.Object> visited)
            /// </summary>
            /// <param name = "visited">class System.Collections.Generic.HashSet<System.Object></param>
            /// <returns>struct UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InternalGetDownloadStatus", "UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.HashSet<System.Object>", 0)]
            public partial UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus INTERNAL_GET_DOWNLOAD_STATUS(nint visited); 
*/
            /// <summary>
            ///   System.Boolean IsValid()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsValid", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_VALID(); 
*/
            /// <summary>
            ///   System.Void Release()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Release", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RELEASE(); 
*/
            /// <summary>
            ///   System.Void ReleaseHandleOnCompletion()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseHandleOnCompletion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RELEASE_HANDLE_ON_COMPLETION(); 
*/
            /// <summary>
            ///   System.Void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove_Completed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>>", 0)]
            public partial void REMOVE_COMPLETED(nint value); 
*/
            /// <summary>
            ///   System.Void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove_CompletedTypeless", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>", 0)]
            public partial void REMOVE_COMPLETED_TYPELESS(nint value); 
*/
            /// <summary>
            ///   System.Void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value)
            /// </summary>
            /// <param name = "value">class System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove_Destroyed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>", 0)]
            public partial void REMOVE_DESTROYED(nint value); 
*/
            /// <summary>
            ///   System.Void set_LocationName(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LocationName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_LOCATION_NAME(nint value); 
*/
            /// <summary>
            ///   System.Object System.Collections.IEnumerator.get_Current()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerator.get_Current", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_ENUMERATORGET_CURRENT(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IEnumerator.MoveNext()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerator.MoveNext", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_ENUMERATOR_MOVE_NEXT(); 
*/
            /// <summary>
            ///   System.Void System.Collections.IEnumerator.Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerator.Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SYSTEM_COLLECTIONS_I_ENUMERATOR_RESET(); 
*/
            /// <summary>
            ///   UnityEngine.Sprite WaitForCompletion()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WaitForCompletion", "UnityEngine.Sprite", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint WAIT_FOR_COMPLETION(); 
*/
        }
    }
}
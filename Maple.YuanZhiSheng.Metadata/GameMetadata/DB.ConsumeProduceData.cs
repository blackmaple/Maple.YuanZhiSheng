namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."ConsumeProduceData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ConsumeProduceData>, Ptr_ConsumeProduceData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "ConsumeProduceData", "DB.ConsumeProduceData")]
    public partial class ConsumeProduceData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ConsumeProduceData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ConsumeProduceData(System.IntPtr ptr) => new Ptr_ConsumeProduceData(ptr);
            public static implicit operator System.IntPtr(Ptr_ConsumeProduceData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ConsumeProduceData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."ConsumeProduceData"]
        /// </summary>
        partial struct Ptr_ConsumeProduceData
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.List<DB.ConsumeProduceData> list
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.ConsumeProduceData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("list", "System.Collections.Generic.List<DB.ConsumeProduceData>")]
            public static partial nint LIST { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Collections.Generic.Dictionary<System.String , DB.ConsumeProduceData> map
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , DB.ConsumeProduceData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("map", "System.Collections.Generic.Dictionary<System.String,DB.ConsumeProduceData>")]
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
            /// 0x18 System.String <CateId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CateId>k__BackingField", "System.String")]
            public partial nint CATE_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Boolean <NoProduce>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<NoProduce>k__BackingField", "System.Boolean")]
            public partial System.Boolean NO_PRODUCE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String <AttributeId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeId>k__BackingField", "System.String")]
            public partial nint ATTRIBUTE_ID { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 <AttributeLimit>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeLimit>k__BackingField", "System.Int32")]
            public partial System.Int32 ATTRIBUTE_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 <ShowLimit>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ShowLimit>k__BackingField", "System.Int32")]
            public partial System.Int32 SHOW_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String <UnlockItemId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UnlockItemId>k__BackingField", "System.String")]
            public partial nint UNLOCK_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32[] <Conditions>k__BackingField
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Conditions>k__BackingField", "System.Int32[]")]
            public partial nint CONDITIONS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String <Effect>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Effect>k__BackingField", "System.String")]
            public partial nint EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String <ExEffects>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ExEffects>k__BackingField", "System.String")]
            public partial nint EX_EFFECTS { get; set; } 
*/

            /// <summary>
            /// 0x58 DB.DBIdInt[] <DefaultCosts>k__BackingField
            /// class ["Assembly-CSharp.dll"."DB"."DBIdInt[]"]
            /// </summary>
            /// <returns>class DB.DBIdInt[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DefaultCosts>k__BackingField", "DB.DBIdInt[]")]
            public partial nint DEFAULT_COSTS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."ConsumeProduceData"]
        /// </summary>
        partial struct Ptr_ConsumeProduceData
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
            /// static  DB.ConsumeProduceData Get(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>class DB.ConsumeProduceData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "DB.ConsumeProduceData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint GET(nint id, System.Boolean showError); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<DB.ConsumeProduceData> GetAll()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.ConsumeProduceData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAll", "System.Collections.Generic.List<DB.ConsumeProduceData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ALL(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.ConsumeProduceData>> GetAllAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.ConsumeProduceData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllAsync", "Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.ConsumeProduceData>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.List<DB.ConsumeProduceData>> GET_ALL_ASYNC(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask<DB.ConsumeProduceData> GetAsync(System.String id, System.Boolean showError)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "showError">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<DB.ConsumeProduceData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAsync", "Cysharp.Threading.Tasks.UniTask<DB.ConsumeProduceData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial Cysharp.Threading.Tasks.UniTask<DB.ConsumeProduceData> GET_ASYNC(nint id, System.Boolean showError); 
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
            ///   System.String get_AttributeId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_AttributeLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ATTRIBUTE_LIMIT(); 
*/
            /// <summary>
            ///   System.String get_CateId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CateId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CATE_ID(); 
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
            ///   DB.DBIdInt[] get_DefaultCosts()
            /// </summary>
            /// <returns>class DB.DBIdInt[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DefaultCosts", "DB.DBIdInt[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEFAULT_COSTS(); 
*/
            /// <summary>
            ///   System.String get_Effect()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Effect", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EFFECT(); 
*/
            /// <summary>
            ///   System.String get_ExEffects()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ExEffects", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EX_EFFECTS(); 
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
            ///   System.Boolean get_NoProduce()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NoProduce", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NO_PRODUCE(); 
*/
            /// <summary>
            ///   System.Int32 get_ShowLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShowLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SHOW_LIMIT(); 
*/
            /// <summary>
            ///   System.String get_UnlockItemId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UnlockItemId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_UNLOCK_ITEM_ID(); 
*/
            /// <summary>
            ///   System.Void set_AttributeId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ATTRIBUTE_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_AttributeLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_ATTRIBUTE_LIMIT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_CateId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CateId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_CATE_ID(nint value); 
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
            ///   System.Void set_DefaultCosts(DB.DBIdInt[] value)
            /// </summary>
            /// <param name = "value">class DB.DBIdInt[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DefaultCosts", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.DBIdInt[]", 0)]
            public partial void SET_DEFAULT_COSTS(nint value); 
*/
            /// <summary>
            ///   System.Void set_Effect(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Effect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_EFFECT(nint value); 
*/
            /// <summary>
            ///   System.Void set_ExEffects(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ExEffects", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_EX_EFFECTS(nint value); 
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
            ///   System.Void set_NoProduce(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NoProduce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NO_PRODUCE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_ShowLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ShowLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_SHOW_LIMIT(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_UnlockItemId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UnlockItemId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_UNLOCK_ITEM_ID(nint value); 
*/
        }
    }
}
using Maple.MonoGameAssistant.Core;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."LocalizationManager"]
    /// [BaseManager<CYLProject.LocalizationManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LocalizationManager>, Ptr_LocalizationManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "LocalizationManager", "CYLProject.LocalizationManager")]
    public partial class LocalizationManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LocalizationManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LocalizationManager(System.IntPtr ptr) => new Ptr_LocalizationManager(ptr);
            public static implicit operator System.IntPtr(Ptr_LocalizationManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LocalizationManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."LocalizationManager"]
        /// </summary>
        partial struct Ptr_LocalizationManager
        {
            /// <summary>
            /// 0x0 System.String LanguageKeyPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint LANGUAGE_KEY_PATH = Assets/Data/DataSet/Localization/Languages_Key.bytes; 
*/
            /// <summary>
            /// 0x0 System.String LanguageValuePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint LANGUAGE_VALUE_PATH = Assets/Data/DataSet/Localization/Languages_{0}.bytes; 
*/
            /// <summary>
            /// 0x0 System.String LanguagePrefsKey
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint LANGUAGE_PREFS_KEY = CYLProject.Language; 
*/
            /// <summary>
            /// 0x0 System.Int32 LanguageNumber
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 LANGUAGE_NUMBER = 8; 
*/
            /// <summary>
            /// 0x0 CYLProject.LocalizationManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."LocalizationManager"]
            /// </summary>
            /// <returns>class CYLProject.LocalizationManager</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.LocalizationManager")]
            public static partial LocalizationManager.Ptr_LocalizationManager _INSTANCE { get; set; } 


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
            /// 0x18 System.Action LanguageChanged
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LanguageChanged", "System.Action")]
            public partial nint LANGUAGE_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Int32> keyDictionary
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("keyDictionary", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint KEY_DICTIONARY { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.Int32 , System.String> valueDictionary
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("valueDictionary", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
            public partial nint VALUE_DICTIONARY { get; set; } 
*/

            /// <summary>
            /// 0x30 Language language
            /// enum ["Assembly-CSharp.dll".""."Language"]
            /// </summary>
            /// <returns>enum Language</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("language", "Language")]
            public partial Language LANGUAGE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Globalization.CultureInfo currentCulture
            /// class ["mscorlib.dll"."System.Globalization"."CultureInfo"]
            /// </summary>
            /// <returns>class System.Globalization.CultureInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("currentCulture", "System.Globalization.CultureInfo")]
            public partial nint CURRENT_CULTURE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."LocalizationManager"]
        /// </summary>
        partial struct Ptr_LocalizationManager
        {
            /// <summary>
            /// static  System.Collections.Generic.List<Language> ConvertLanguageFlag(LanguageFlag flag)
            /// </summary>
            /// <param name = "flag">enum LanguageFlag</param>
            /// <returns>class System.Collections.Generic.List<Language></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertLanguageFlag", "System.Collections.Generic.List<Language>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LanguageFlag", 0)]
            public static partial nint CONVERT_LANGUAGE_FLAG(LanguageFlag flag); 
*/
            /// <summary>
            /// static  System.String GetEnumKey(System.Enum value)
            /// </summary>
            /// <param name = "value">abstract class System.Enum</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumKey", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Enum", 0)]
            public static partial nint GET_ENUM_KEY(nint value); 
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
            ///   System.Void add_LanguageChanged(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add_LanguageChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
            public partial void ADD_LANGUAGE_CHANGED(nint value); 
*/
            /// <summary>
            ///   System.String Get(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial PMonoString GET(nint key); 

            /// <summary>
            ///   System.String Get(System.String key, System.Object[] args)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <param name = "args">class System.Object[]</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object[]", 1)]
            public partial nint GET(nint key, nint args); 
*/
            /// <summary>
            ///   System.String Get(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET(System.Int32 id); 
*/
            /// <summary>
            ///   System.Globalization.CultureInfo get_CurrentCulture()
            /// </summary>
            /// <returns>class System.Globalization.CultureInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurrentCulture", "System.Globalization.CultureInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CURRENT_CULTURE(); 
*/
            /// <summary>
            ///   Language get_Language()
            /// </summary>
            /// <returns>enum Language</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Language", "Language", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Language GET_LANGUAGE(); 
*/
            /// <summary>
            ///   System.String GetLocalizedImageName(System.String spriteName)
            /// </summary>
            /// <param name = "spriteName">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLocalizedImageName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_LOCALIZED_IMAGE_NAME(nint spriteName); 
*/
            /// <summary>
            ///   System.Void InitLanguage()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitLanguage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_LANGUAGE(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask LoadKeyFile()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadKeyFile", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask LOAD_KEY_FILE(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask LoadValueFile()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadValueFile", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask LOAD_VALUE_FILE(); 
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
            ///   System.Void remove_LanguageChanged(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove_LanguageChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
            public partial void REMOVE_LANGUAGE_CHANGED(nint value); 
*/
            /// <summary>
            ///   System.Void set_Language(Language value)
            /// </summary>
            /// <param name = "value">enum Language</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Language", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Language", 0)]
            public partial void SET_LANGUAGE(Language value); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask SetLanguage(Language value)
            /// </summary>
            /// <param name = "value">enum Language</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLanguage", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Language", 0)]
            public partial Cysharp.Threading.Tasks.UniTask SET_LANGUAGE(Language value); 
*/
            /// <summary>
            ///   System.Void UpdateCulture()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCulture", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_CULTURE(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_LocalizationManager
        {
            /// <summary>
            /// static  CYLProject.LocalizationManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.LocalizationManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.LocalizationManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
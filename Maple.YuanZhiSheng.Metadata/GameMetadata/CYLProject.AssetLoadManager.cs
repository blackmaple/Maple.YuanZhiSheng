namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."AssetLoadManager"]
    /// [BaseManager<CYLProject.AssetLoadManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AssetLoadManager>, Ptr_AssetLoadManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "AssetLoadManager", "CYLProject.AssetLoadManager")]
    public partial class AssetLoadManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AssetLoadManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AssetLoadManager(System.IntPtr ptr) => new Ptr_AssetLoadManager(ptr);
            public static implicit operator System.IntPtr(Ptr_AssetLoadManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AssetLoadManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."AssetLoadManager"]
        /// </summary>
        partial struct Ptr_AssetLoadManager
        {
            /// <summary>
            /// 0x0 System.String DataPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint DATA_PATH = Assets/Data/DataSet/JsonData/{0}.bytes; 
*/
            /// <summary>
            /// 0x0 System.String StoryDataPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint STORY_DATA_PATH = Assets/Data/DataSet/Story/{0}.bytes; 
*/
            /// <summary>
            /// 0x0 System.String UIPrefabPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint UI_PREFAB_PATH = Assets/Prefabs/UI/{0}.prefab; 
*/
            /// <summary>
            /// 0x0 CYLProject.AssetLoadManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."AssetLoadManager"]
            /// </summary>
            /// <returns>class CYLProject.AssetLoadManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.AssetLoadManager")]
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
            /// 0x18 Newtonsoft.Json.Converters.StringEnumConverter stringEnumConverter
            /// class ["Newtonsoft.Json.dll"."Newtonsoft.Json.Converters"."StringEnumConverter"]
            /// </summary>
            /// <returns>class Newtonsoft.Json.Converters.StringEnumConverter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("stringEnumConverter", "Newtonsoft.Json.Converters.StringEnumConverter")]
            public partial nint STRING_ENUM_CONVERTER { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> _AOHandleCache
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_AOHandleCache", "System.Collections.Generic.Dictionary<System.String,UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>")]
            public partial nint _AO_HANDLE_CACHE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>> _spriteHandleCache
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_spriteHandleCache", "System.Collections.Generic.Dictionary<System.String,UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>>")]
            public partial nint _SPRITE_HANDLE_CACHE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , System.Int32> _spriteLoadCountCache
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_spriteLoadCountCache", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint _SPRITE_LOAD_COUNT_CACHE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."AssetLoadManager"]
        /// </summary>
        partial struct Ptr_AssetLoadManager
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
            ///   System.Int32 ChangeSpriteLoadCount(System.String assetPath, System.Int32 changeValue)
            /// </summary>
            /// <param name = "assetPath">class System.String</param>
            /// <param name = "changeValue">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeSpriteLoadCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 CHANGE_SPRITE_LOAD_COUNT(nint assetPath, System.Int32 changeValue); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> InstantiateAsync(System.String assetName, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 3)]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> INSTANTIATE_ASYNC(nint assetName, nint parent, System.Boolean instantiateInWorldSpace, nint cts); 
*/
            /// <summary>
            ///   T Load(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD(nint assetName); 
*/
            /// <summary>
            ///   T LoadAsset(System.String assetName, System.Boolean release)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <param name = "release">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAsset", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint LOAD_ASSET(nint assetName, System.Boolean release); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> LoadAssetAsync(System.String assetPath, System.Boolean release, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "assetPath">class System.String</param>
            /// <param name = "release">struct System.Boolean</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAssetAsync", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 2)]
            public partial Cysharp.Threading.Tasks.UniTask<T> LOAD_ASSET_ASYNC(nint assetPath, System.Boolean release, nint cts); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> LoadAsync(System.String assetName, System.Boolean release, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <param name = "release">struct System.Boolean</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAsync", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 2)]
            public partial Cysharp.Threading.Tasks.UniTask<T> LOAD_ASYNC(nint assetName, System.Boolean release, nint cts); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.U2D.SpriteAtlas> LoadAtlasAsync(System.String assetName, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.U2D.SpriteAtlas></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAtlasAsync", "Cysharp.Threading.Tasks.UniTask<UnityEngine.U2D.SpriteAtlas>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.U2D.SpriteAtlas> LOAD_ATLAS_ASYNC(nint assetName, nint cts); 
*/
            /// <summary>
            ///   T LoadData(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadData", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD_DATA(nint assetName); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> LoadDataAsync(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadDataAsync", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial Cysharp.Threading.Tasks.UniTask<T> LOAD_DATA_ASYNC(nint assetName); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> LoadLanguageAsync(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadLanguageAsync", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial Cysharp.Threading.Tasks.UniTask<T> LOAD_LANGUAGE_ASYNC(nint assetName); 
*/
            /// <summary>
            ///   UnityEngine.GameObject LoadPrefab(System.String path, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadPrefab", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public partial nint LOAD_PREFAB(nint path, nint parent); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>> LoadSpriteAsync(System.String AssetPath, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "AssetPath">class System.String</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSpriteAsync", "Cysharp.Threading.Tasks.UniTask<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Sprite>> LOAD_SPRITE_ASYNC(nint AssetPath, nint cts); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadSpriteAsync(System.String atlasPath, System.String name)
            /// </summary>
            /// <param name = "atlasPath">class System.String</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSpriteAsync", "Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LOAD_SPRITE_ASYNC(nint atlasPath, nint name); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.String> LoadStoryDataAsync(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadStoryDataAsync", "Cysharp.Threading.Tasks.UniTask<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial Cysharp.Threading.Tasks.UniTask<System.String> LOAD_STORY_DATA_ASYNC(nint assetName); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTexture2DAsync(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadTexture2DAsync", "Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LOAD_TEXTURE2_D_ASYNC(nint name); 
*/
            /// <summary>
            ///   UnityEngine.GameObject LoadUIPrefab(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadUIPrefab", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD_UI_PREFAB(nint path); 
*/
            /// <summary>
            ///   System.Void ReleaseAsset(System.String assetName)
            /// </summary>
            /// <param name = "assetName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseAsset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RELEASE_ASSET(nint assetName); 
*/
            /// <summary>
            ///   System.Void ReleaseAtlas(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle)
            /// </summary>
            /// <param name = "handle">struct UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseAtlas", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle", 0)]
            public partial void RELEASE_ATLAS(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle); 
*/
            /// <summary>
            ///   System.Void ReleaseGameObject(UnityEngine.GameObject go)
            /// </summary>
            /// <param name = "go">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseGameObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public partial void RELEASE_GAME_OBJECT(nint go); 
*/
            /// <summary>
            ///   System.Void ReleaseSprite(System.String assetPath)
            /// </summary>
            /// <param name = "assetPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReleaseSprite", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RELEASE_SPRITE(nint assetPath); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_AssetLoadManager
        {
            /// <summary>
            /// static  CYLProject.AssetLoadManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.AssetLoadManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.AssetLoadManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
using Maple.MonoGameAssistant.Core;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."WinManager"]
    /// [BaseMonoManager<CYLProject.WinManager>]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_WinManager>, Ptr_WinManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "WinManager", "CYLProject.WinManager")]
    public partial class WinManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_WinManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_WinManager(System.IntPtr ptr) => new Ptr_WinManager(ptr);
            public static implicit operator System.IntPtr(Ptr_WinManager ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_WinManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."WinManager"]
        /// </summary>
        partial struct Ptr_WinManager
        {
            /// <summary>
            /// 0x0 System.String RootPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint ROOT_PATH = Assets/Prefabs/Main/UIRoot.prefab; 
*/
            /// <summary>
            /// 0x0 System.String objectIsNullMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint OBJECT_IS_NULL_MESSAGE = The Object you want to instantiate is null.; 
*/
            /// <summary>
            /// 0x0 System.String cloneDestroyedMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint CLONE_DESTROYED_MESSAGE = Instantiate failed because the clone was destroyed during creati; 
*/
            /// <summary>
            /// 0x0 UnityEngine.Vector2 ScreenSize
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ScreenSize", "UnityEngine.Vector2")]
           public static partial UnityEngine.Vector2 SCREEN_SIZE { get; set; } 
*/

            /// <summary>
            /// 0x0 CYLProject.WinManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."WinManager"]
            /// </summary>
            /// <returns>class CYLProject.WinManager</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.WinManager")]
            public static partial WinManager.Ptr_WinManager _INSTANCE { get; set; }


            /// <summary>
            /// 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OffsetOfInstanceIDInCPlusPlusObject", "System.Int32")]
           public static partial System.Int32 OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT { get; set; } 
*/

            /// <summary>
            /// 0x8 UnityEngine.Vector2Int SaveScreenShotSize
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2Int"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2Int</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SaveScreenShotSize", "UnityEngine.Vector2Int")]
           public static partial UnityEngine.Vector2Int SAVE_SCREEN_SHOT_SIZE { get; set; } 
*/

            /// <summary>
            /// 0x10 System.IntPtr m_CachedPtr
            /// struct ["mscorlib.dll"."System"."IntPtr"]
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CachedPtr", "System.IntPtr")]
           public partial System.IntPtr M_CACHED_PTR { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
            /// class ["mscorlib.dll"."System.Threading"."CancellationTokenSource"]
            /// </summary>
            /// <returns>class System.Threading.CancellationTokenSource</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CancellationTokenSource", "System.Threading.CancellationTokenSource")]
           public partial nint M_CANCELLATION_TOKEN_SOURCE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Boolean <InitCompleted>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<InitCompleted>k__BackingField", "System.Boolean")]
           public partial System.Boolean INIT_COMPLETED { get; set; } 
*/

            /// <summary>
            /// 0x28 UnityEngine.Camera <UICamera>k__BackingField
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Camera"]
            /// </summary>
            /// <returns>class UnityEngine.Camera</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UICamera>k__BackingField", "UnityEngine.Camera")]
           public partial nint UI_CAMERA { get; set; } 
*/

            /// <summary>
            /// 0x30 UnityEngine.EventSystems.EventSystem <EventSystem>k__BackingField
            /// class ["UnityEngine.UI.dll"."UnityEngine.EventSystems"."EventSystem"]
            /// </summary>
            /// <returns>class UnityEngine.EventSystems.EventSystem</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EventSystem>k__BackingField", "UnityEngine.EventSystems.EventSystem")]
           public partial nint EVENT_SYSTEM { get; set; } 
*/

            /// <summary>
            /// 0x38 UnityEngine.InputSystem.UI.InputSystemUIInputModule <UIInput>k__BackingField
            /// class ["Unity.InputSystem.dll"."UnityEngine.InputSystem.UI"."InputSystemUIInputModule"]
            /// </summary>
            /// <returns>class UnityEngine.InputSystem.UI.InputSystemUIInputModule</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UIInput>k__BackingField", "UnityEngine.InputSystem.UI.InputSystemUIInputModule")]
           public partial nint UI_INPUT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean <UIInputEnable>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UIInputEnable>k__BackingField", "System.Boolean")]
           public partial System.Boolean UI_INPUT_ENABLE { get; set; } 
*/

            /// <summary>
            /// 0x41 System.Boolean <OnlyMainMenuAndTutorialExtra>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OnlyMainMenuAndTutorialExtra>k__BackingField", "System.Boolean")]
           public partial System.Boolean ONLY_MAIN_MENU_AND_TUTORIAL_EXTRA { get; set; } 
*/

            /// <summary>
            /// 0x48 BaseWin <FocusWin>k__BackingField
            /// abstract class ["Assembly-CSharp.dll".""."BaseWin"]
            /// </summary>
            /// <returns>abstract class BaseWin</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<FocusWin>k__BackingField", "BaseWin")]
           public partial nint FOCUS_WIN { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Action _onOpenWinListChange
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_onOpenWinListChange", "System.Action")]
           public partial nint _ON_OPEN_WIN_LIST_CHANGE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.List<BaseWin> OpenWin
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BaseWin></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OpenWin", "System.Collections.Generic.List<BaseWin>")]
           public partial nint OPEN_WIN { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<BaseWin> PopFullScreenWinCache
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BaseWin></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PopFullScreenWinCache", "System.Collections.Generic.List<BaseWin>")]
           public partial nint POP_FULL_SCREEN_WIN_CACHE { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<BaseWin> toOpenList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BaseWin></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("toOpenList", "System.Collections.Generic.List<BaseWin>")]
           public partial nint TO_OPEN_LIST { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.Dictionary<System.String , System.Boolean> _inputModifier
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Boolean></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_inputModifier", "System.Collections.Generic.Dictionary<System.String,System.Boolean>")]
           public partial nint _INPUT_MODIFIER { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.Dictionary<CYLProject.WinManager.EWinSortingGroup , UnityEngine.Transform> _sortingRoot
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.WinManager.EWinSortingGroup , UnityEngine.Transform></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_sortingRoot", "System.Collections.Generic.Dictionary<CYLProject.WinManager.EWinSortingGroup,UnityEngine.Transform>")]
           public partial nint _SORTING_ROOT { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.Dictionary<System.Type , BasePanel> _panelList
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Type , BasePanel></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_panelList", "System.Collections.Generic.Dictionary<System.Type,BasePanel>")]
           public partial nint _PANEL_LIST { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.Dictionary<System.Type , BaseWin> _winDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Type , BaseWin></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_winDict", "System.Collections.Generic.Dictionary<System.Type,BaseWin>")]
           public partial nint _WIN_DICT { get; set; } 
*/

            /// <summary>
            /// 0x90 UnityEngine.Transform _root
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Transform"]
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_root", "UnityEngine.Transform")]
           public partial nint _ROOT { get; set; } 
*/

            /// <summary>
            /// 0x98 UnityEngine.Transform _mask
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Transform"]
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mask", "UnityEngine.Transform")]
           public partial nint _MASK { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Boolean _lockOpen
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lockOpen", "System.Boolean")]
           public partial System.Boolean _LOCK_OPEN { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 _refreshIdx
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_refreshIdx", "System.Int32")]
           public partial System.Int32 _REFRESH_IDX { get; set; } 
*/

            /// <summary>
            /// 0xA8 UnityEngine.RenderTexture _maskRT
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."RenderTexture"]
            /// </summary>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_maskRT", "UnityEngine.RenderTexture")]
           public partial nint _MASK_RT { get; set; } 
*/

            /// <summary>
            /// 0xB0 UnityEngine.RenderTexture _screenShotRT
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."RenderTexture"]
            /// </summary>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_screenShotRT", "UnityEngine.RenderTexture")]
           public partial nint _SCREEN_SHOT_RT { get; set; } 
*/

            /// <summary>
            /// 0xB8 UnityEngine.Texture2D _screenShotTex
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Texture2D"]
            /// </summary>
            /// <returns>class UnityEngine.Texture2D</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_screenShotTex", "UnityEngine.Texture2D")]
           public partial nint _SCREEN_SHOT_TEX { get; set; } 
*/

            /// <summary>
            /// 0xC0 ObjectPool<System.Type , BasePanel> objectPool
            /// class ["Assembly-CSharp.dll".""."ObjectPool`2"]
            /// </summary>
            /// <returns>class ObjectPool<System.Type , BasePanel></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("objectPool", "ObjectPool<System.Type,BasePanel>")]
           public partial nint OBJECT_POOL { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Threading.CancellationTokenSource _cts
            /// class ["mscorlib.dll"."System.Threading"."CancellationTokenSource"]
            /// </summary>
            /// <returns>class System.Threading.CancellationTokenSource</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_cts", "System.Threading.CancellationTokenSource")]
           public partial nint _CTS { get; set; } 
*/

            /// <summary>
            /// 0xD0 UnityEngine.UI.Image <ImageClear>k__BackingField
            /// class ["UnityEngine.UI.dll"."UnityEngine.UI"."Image"]
            /// </summary>
            /// <returns>class UnityEngine.UI.Image</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ImageClear>k__BackingField", "UnityEngine.UI.Image")]
           public partial nint IMAGE_CLEAR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."WinManager"]
        /// </summary>
        partial struct Ptr_WinManager
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void CCTOR(); 
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
            ///   System.Void add__onOpenWinListChange(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add__onOpenWinListChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
           public partial void ADD__ON_OPEN_WIN_LIST_CHANGE(nint value); 
*/
            /// <summary>
            ///   System.Void AddOpenWin(BaseWin w)
            /// </summary>
            /// <param name = "w">abstract class BaseWin</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddOpenWin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           public partial void ADD_OPEN_WIN(nint w); 
*/
            /// <summary>
            ///   System.Void CancelShowDetail()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelShowDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CANCEL_SHOW_DETAIL(); 
*/
            /// <summary>
            ///   System.Void CheckToOpen()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckToOpen", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CHECK_TO_OPEN(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask Close(System.Boolean openFullWin)
            /// </summary>
            /// <param name = "openFullWin">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Close", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial Cysharp.Threading.Tasks.UniTask CLOSE(System.Boolean openFullWin); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask Close(BaseWin w, System.Boolean openFullWin)
            /// </summary>
            /// <param name = "w">abstract class BaseWin</param>
            /// <param name = "openFullWin">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Close", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial Cysharp.Threading.Tasks.UniTask CLOSE(nint w, System.Boolean openFullWin); 
*/
            /// <summary>
            ///   System.Void CloseAll(System.Boolean keepPassWin)
            /// </summary>
            /// <param name = "keepPassWin">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CloseAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void CLOSE_ALL(System.Boolean keepPassWin); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask DestroyWin()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyWin", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial Cysharp.Threading.Tasks.UniTask DESTROY_WIN(); 
*/
            /// <summary>
            ///   System.Void DestroyWin(BaseWin w)
            /// </summary>
            /// <param name = "w">abstract class BaseWin</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyWin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           public partial void DESTROY_WIN(nint w); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> Get()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial Cysharp.Threading.Tasks.UniTask<T> GET(); 
*/
            /// <summary>
            ///   UnityEngine.EventSystems.EventSystem get_EventSystem()
            /// </summary>
            /// <returns>class UnityEngine.EventSystems.EventSystem</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EventSystem", "UnityEngine.EventSystems.EventSystem", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_EVENT_SYSTEM(); 
*/
            /// <summary>
            ///   BaseWin get_FocusWin()
            /// </summary>
            /// <returns>abstract class BaseWin</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FocusWin", "BaseWin", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_FOCUS_WIN(); 
*/
            /// <summary>
            ///   UnityEngine.UI.Image get_ImageClear()
            /// </summary>
            /// <returns>class UnityEngine.UI.Image</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ImageClear", "UnityEngine.UI.Image", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_IMAGE_CLEAR(); 
*/
            /// <summary>
            ///   System.Boolean get_OnlyMainMenuAndTutorialExtra()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OnlyMainMenuAndTutorialExtra", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_ONLY_MAIN_MENU_AND_TUTORIAL_EXTRA(); 
*/
            /// <summary>
            ///   UnityEngine.Camera get_UICamera()
            /// </summary>
            /// <returns>class UnityEngine.Camera</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UICamera", "UnityEngine.Camera", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_UI_CAMERA(); 
*/
            /// <summary>
            ///   UnityEngine.InputSystem.UI.InputSystemUIInputModule get_UIInput()
            /// </summary>
            /// <returns>class UnityEngine.InputSystem.UI.InputSystemUIInputModule</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UIInput", "UnityEngine.InputSystem.UI.InputSystemUIInputModule", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_UI_INPUT(); 
*/
            /// <summary>
            ///   System.Boolean get_UIInputEnable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UIInputEnable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_UI_INPUT_ENABLE(); 
*/
            /// <summary>
            ///   UnityEngine.RenderTexture GetCameraRT()
            /// </summary>
            /// <returns>class UnityEngine.RenderTexture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCameraRT", "UnityEngine.RenderTexture", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_CAMERA_RT(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> GetPanel()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPanel", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial Cysharp.Threading.Tasks.UniTask<T> GET_PANEL(); 
*/
            /// <summary>
            ///   System.Byte[] GetScreenShotData()
            /// </summary>
            /// <returns>class System.Byte[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScreenShotData", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_SCREEN_SHOT_DATA(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> HidePanel()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HidePanel", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial Cysharp.Threading.Tasks.UniTask<T> HIDE_PANEL(); 
*/
            /// <summary>
            ///   System.Void OnDisable()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDisable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void ON_DISABLE(); 
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
            ///   Cysharp.Threading.Tasks.UniTask Open(BaseWin ret, System.Boolean isFullScreen)
            /// </summary>
            /// <param name = "ret">abstract class BaseWin</param>
            /// <param name = "isFullScreen">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Open", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial Cysharp.Threading.Tasks.UniTask OPEN(nint ret, System.Boolean isFullScreen); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> Open(System.Boolean isFullScreen)
            /// </summary>
            /// <param name = "isFullScreen">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Open", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial Cysharp.Threading.Tasks.UniTask<T> OPEN(System.Boolean isFullScreen); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> Pop(System.Boolean front)
            /// </summary>
            /// <param name = "front">struct System.Boolean</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Pop", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial Cysharp.Threading.Tasks.UniTask<T> POP(System.Boolean front); 
*/
            /// <summary>
            ///   System.Void Preload()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Preload", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void PRELOAD(); 
*/
            /// <summary>
            ///   System.Void RefreshWinFocus()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshWinFocus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void REFRESH_WIN_FOCUS(); 
*/
            /// <summary>
            ///   System.Void remove__onOpenWinListChange(System.Action value)
            /// </summary>
            /// <param name = "value">class System.Action</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove__onOpenWinListChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
           public partial void REMOVE__ON_OPEN_WIN_LIST_CHANGE(nint value); 
*/
            /// <summary>
            ///   System.Void RemoveOpenWin(BaseWin w)
            /// </summary>
            /// <param name = "w">abstract class BaseWin</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveOpenWin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           public partial void REMOVE_OPEN_WIN(nint w); 
*/
            /// <summary>
            ///   System.Void set_EventSystem(UnityEngine.EventSystems.EventSystem value)
            /// </summary>
            /// <param name = "value">class UnityEngine.EventSystems.EventSystem</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EventSystem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.EventSystems.EventSystem", 0)]
           public partial void SET_EVENT_SYSTEM(nint value); 
*/
            /// <summary>
            ///   System.Void set_FocusWin(BaseWin value)
            /// </summary>
            /// <param name = "value">abstract class BaseWin</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FocusWin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseWin", 0)]
           public partial void SET_FOCUS_WIN(nint value); 
*/
            /// <summary>
            ///   System.Void set_ImageClear(UnityEngine.UI.Image value)
            /// </summary>
            /// <param name = "value">class UnityEngine.UI.Image</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ImageClear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Image", 0)]
           public partial void SET_IMAGE_CLEAR(nint value); 
*/
            /// <summary>
            ///   System.Void set_OnlyMainMenuAndTutorialExtra(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OnlyMainMenuAndTutorialExtra", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_ONLY_MAIN_MENU_AND_TUTORIAL_EXTRA(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_UICamera(UnityEngine.Camera value)
            /// </summary>
            /// <param name = "value">class UnityEngine.Camera</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UICamera", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Camera", 0)]
           public partial void SET_UI_CAMERA(nint value); 
*/
            /// <summary>
            ///   System.Void set_UIInput(UnityEngine.InputSystem.UI.InputSystemUIInputModule value)
            /// </summary>
            /// <param name = "value">class UnityEngine.InputSystem.UI.InputSystemUIInputModule</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UIInput", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InputSystem.UI.InputSystemUIInputModule", 0)]
           public partial void SET_UI_INPUT(nint value); 
*/
            /// <summary>
            ///   System.Void set_UIInputEnable(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UIInputEnable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void SET_UI_INPUT_ENABLE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetImageSpriteAsync(UnityEngine.UI.Image image, System.String path, System.Threading.CancellationTokenSource cts, System.Boolean native, System.Boolean show)
            /// </summary>
            /// <param name = "image">class UnityEngine.UI.Image</param>
            /// <param name = "path">class System.String</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <param name = "native">struct System.Boolean</param>
            /// <param name = "show">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetImageSpriteAsync", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Image", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           public partial void SET_IMAGE_SPRITE_ASYNC(nint image, nint path, nint cts, System.Boolean native, System.Boolean show); 
*/
            /// <summary>
            ///   System.Void SetInputState(System.String key, System.Boolean value)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetInputState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void SET_INPUT_STATE(nint key, System.Boolean value); 
*/
            /// <summary>
            ///   System.Void ShowAsk(System.String title, System.String tip, System.Action<System.Boolean> callback)
            /// </summary>
            /// <param name = "title">class System.String</param>
            /// <param name = "tip">class System.String</param>
            /// <param name = "callback">class System.Action<System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowAsk", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<System.Boolean>", 2)]
           public partial void SHOW_ASK(nint title, nint tip, nint callback); 
*/
            /// <summary>
            ///   System.Void ShowAsk(System.String title, System.String tip, System.Int32 cap, System.Action<System.Boolean , System.Int32> callback)
            /// </summary>
            /// <param name = "title">class System.String</param>
            /// <param name = "tip">class System.String</param>
            /// <param name = "cap">struct System.Int32</param>
            /// <param name = "callback">class System.Action<System.Boolean , System.Int32></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowAsk", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<System.Boolean,System.Int32>", 3)]
           public partial void SHOW_ASK(nint title, nint tip, System.Int32 cap, nint callback); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowAskAsync(System.String title, System.String tip, System.Action<System.Boolean> callback)
            /// </summary>
            /// <param name = "title">class System.String</param>
            /// <param name = "tip">class System.String</param>
            /// <param name = "callback">class System.Action<System.Boolean></param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowAskAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<System.Boolean>", 2)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_ASK_ASYNC(nint title, nint tip, nint callback); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowAskAsync(System.String title, System.String tip, System.Int32 cap, System.Action<System.Boolean , System.Int32> callback)
            /// </summary>
            /// <param name = "title">class System.String</param>
            /// <param name = "tip">class System.String</param>
            /// <param name = "cap">struct System.Int32</param>
            /// <param name = "callback">class System.Action<System.Boolean , System.Int32></param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowAskAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<System.Boolean,System.Int32>", 3)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_ASK_ASYNC(nint title, nint tip, System.Int32 cap, nint callback); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowCirclePass(System.Action curTask)
            /// </summary>
            /// <param name = "curTask">class System.Action</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowCirclePass", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action", 0)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_CIRCLE_PASS(nint curTask); 
*/
            /// <summary>
            ///   System.Void ShowDescDetail(UnityEngine.RectTransform rect, System.String desc, System.Boolean limitWidth, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "limitWidth">struct System.Boolean</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowDescDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial void SHOW_DESC_DETAIL(nint rect, nint desc, System.Boolean limitWidth, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowDescDetailAsync(UnityEngine.RectTransform rect, System.String desc, System.Boolean limitWidth, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "limitWidth">struct System.Boolean</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowDescDetailAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_DESC_DETAIL_ASYNC(nint rect, nint desc, System.Boolean limitWidth, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   System.Void ShowDescriptionDetail(UnityEngine.RectTransform rect, System.String desc, System.String desc1, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "desc1">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowDescriptionDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial void SHOW_DESCRIPTION_DETAIL(nint rect, nint desc, nint desc1, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowDescriptionDetailAsync(UnityEngine.RectTransform rect, System.String desc, System.String desc1, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "desc1">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowDescriptionDetailAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_DESCRIPTION_DETAIL_ASYNC(nint rect, nint desc, nint desc1, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   System.Void ShowItemDetail(UnityEngine.RectTransform rect, System.String itemId, System.String saveId, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "itemId">class System.String</param>
            /// <param name = "saveId">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowItemDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial void SHOW_ITEM_DETAIL(nint rect, nint itemId, nint saveId, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowItemDetailAsync(UnityEngine.RectTransform rect, System.String itemId, System.String saveId, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "itemId">class System.String</param>
            /// <param name = "saveId">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowItemDetailAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_ITEM_DETAIL_ASYNC(nint rect, nint itemId, nint saveId, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   System.Void ShowNameDescDetail(UnityEngine.RectTransform rect, System.String name, System.String desc, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowNameDescDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial void SHOW_NAME_DESC_DETAIL(nint rect, nint name, nint desc, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowNameDescDetailAsync(UnityEngine.RectTransform rect, System.String name, System.String desc, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowNameDescDetailAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 3)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_NAME_DESC_DETAIL_ASYNC(nint rect, nint name, nint desc, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<T> ShowPanel()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<T></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowPanel", "Cysharp.Threading.Tasks.UniTask<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial Cysharp.Threading.Tasks.UniTask<T> SHOW_PANEL(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowPass(System.Func<Cysharp.Threading.Tasks.UniTask> curTask)
            /// </summary>
            /// <param name = "curTask">class System.Func<Cysharp.Threading.Tasks.UniTask></param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowPass", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Func<Cysharp.Threading.Tasks.UniTask>", 0)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_PASS(nint curTask); 
*/
            /// <summary>
            ///   System.Void ShowPlayerTalentDetail(UnityEngine.RectTransform rect, System.String talentId, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "talentId">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowPlayerTalentDetail", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 2)]
           public partial void SHOW_PLAYER_TALENT_DETAIL(nint rect, nint talentId, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowPlayerTalentDetailAsync(UnityEngine.RectTransform rect, System.String talentId, CYLProject.DetailAnchor anchor)
            /// </summary>
            /// <param name = "rect">class UnityEngine.RectTransform</param>
            /// <param name = "talentId">class System.String</param>
            /// <param name = "anchor">enum CYLProject.DetailAnchor</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowPlayerTalentDetailAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.RectTransform", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.DetailAnchor", 2)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_PLAYER_TALENT_DETAIL_ASYNC(nint rect, nint talentId, CYLProject.DetailAnchor anchor); 
*/
            /// <summary>
            ///   System.Void ShowTip(CYLProject.TipType type, System.String desc, System.String audioId)
            /// </summary>
            /// <param name = "type">enum CYLProject.TipType</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "audioId">class System.String</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.TipType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void SHOW_TIP(TipType type, PMonoString desc, nint audioId = default);

            /// <summary>
            ///   System.Void ShowTip(CYLProject.TipType type, System.String id, System.Int32 amount, System.Int32 resType)
            /// </summary>
            /// <param name = "type">enum CYLProject.TipType</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "amount">struct System.Int32</param>
            /// <param name = "resType">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.TipType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           public partial void SHOW_TIP(CYLProject.TipType type, nint id, System.Int32 amount, System.Int32 resType); 
*/
            /// <summary>
            ///   System.Void ShowTip(CYLProject.TipType type, System.String id, System.Single fill, System.Single progress)
            /// </summary>
            /// <param name = "type">enum CYLProject.TipType</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "fill">struct System.Single</param>
            /// <param name = "progress">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.TipType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
           public partial void SHOW_TIP(CYLProject.TipType type, nint id, System.Single fill, System.Single progress); 
*/
            /// <summary>
            ///   System.Void ShowTip(CYLProject.TipType type, System.String id, System.String desc, System.String audioId)
            /// </summary>
            /// <param name = "type">enum CYLProject.TipType</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "desc">class System.String</param>
            /// <param name = "audioId">class System.String</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.TipType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
           public partial void SHOW_TIP(CYLProject.TipType type, nint id, nint desc, nint audioId); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask ShowTipAsync(CYLProject.TipType type, System.String id, System.String arg, System.Int32 amount, System.Int32 resType, System.Single fill, System.Single progress, System.String audioId)
            /// </summary>
            /// <param name = "type">enum CYLProject.TipType</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "arg">class System.String</param>
            /// <param name = "amount">struct System.Int32</param>
            /// <param name = "resType">struct System.Int32</param>
            /// <param name = "fill">struct System.Single</param>
            /// <param name = "progress">struct System.Single</param>
            /// <param name = "audioId">class System.String</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowTipAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.TipType", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 5)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 6)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 7)]
           public partial Cysharp.Threading.Tasks.UniTask SHOW_TIP_ASYNC(CYLProject.TipType type, nint id, nint arg, System.Int32 amount, System.Int32 resType, System.Single fill, System.Single progress, nint audioId); 
*/
            /// <summary>
            ///   System.Void UICameraAddToMain()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UICameraAddToMain", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void UI_CAMERA_ADD_TO_MAIN(); 
*/
            /// <summary>
            ///   System.Void UpdateAllWin()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAllWin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void UPDATE_ALL_WIN(); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Object"]
        /// </summary>
        partial struct Ptr_WinManager
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name = "arg">class System.Object</param>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNullArgument", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CHECK_NULL_ARGUMENT(nint arg, nint message); 
*/
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name = "lhs">class UnityEngine.Object</param>
            /// <param name = "rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareBaseObjects", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean COMPARE_BASE_OBJECTS(nint lhs, nint rhs); 
*/
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CurrentThreadIsMainThread", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean CURRENT_THREAD_IS_MAIN_THREAD(); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial void DESTROY_IMMEDIATE(nint obj, System.Boolean allowDestroyingAssets); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_IMMEDIATE(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY_OBJECT(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_OBJECT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoesObjectWithInstanceIDExist", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name = "target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DontDestroyOnLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DONT_DESTROY_ON_LOAD(nint target); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FIND_OBJECT_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_OBJECT_OF_TYPE(); 
*/
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 1)]
            public static partial nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 2)]
            public static partial nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 0)]
            public static partial nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 1)]
            public static partial nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_OBJECTS_OF_TYPE(); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeAll", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_ALL(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeIncludingAssets", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSceneObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_SCENE_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceLoadFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FORCE_LOAD_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint GET_NAME(nint obj); 
*/
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOffsetOfInstanceIDInCPlusPlusObject", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT(); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.SceneManagement.Scene scene)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene", 1)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.SceneManagement.Scene scene); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 1)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean instantiateInWorldSpace); 
*/
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE_ASYNC(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE_ASYNC(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE_ASYNC(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, nint parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
            /// <param name = "rotations">struct System.ReadOnlySpan<UnityEngine.Quaternion></param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Vector3>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Quaternion>", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
            /// <param name = "rotations">struct System.ReadOnlySpan<UnityEngine.Quaternion></param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Vector3>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Quaternion>", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 1)]
            public static partial nint INSTANTIATE_ASYNC(nint original, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 2)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
            /// <param name = "rotations">struct System.ReadOnlySpan<UnityEngine.Quaternion></param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Vector3>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Quaternion>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INTERNAL_CLONE_SINGLE(nint data); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParams(UnityEngine.Object data, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParams", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARAMS(nint data, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParams_Injected(UnityEngine.Object data, UnityEngine.InstantiateParameters& parameters)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParams_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters&", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARAMS_INJECTED(nint data, UnityEngine.InstantiateParameters &parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARENT(nint data, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithScene(UnityEngine.Object data, UnityEngine.SceneManagement.Scene scene)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithScene", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_SCENE(nint data, UnityEngine.SceneManagement.Scene scene); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithScene_Injected(UnityEngine.Object data, UnityEngine.SceneManagement.Scene& scene)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithScene_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene&", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_SCENE_INJECTED(nint data, UnityEngine.SceneManagement.Scene &scene); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation Internal_InstantiateAsyncWithParams(UnityEngine.Object original, System.Int32 count, UnityEngine.InstantiateParameters parameters, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <param name = "positions">struct System.IntPtr</param>
            /// <param name = "positionsCount">struct System.Int32</param>
            /// <param name = "rotations">struct System.IntPtr</param>
            /// <param name = "rotationsCount">struct System.Int32</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateAsyncWithParams", "UnityEngine.AsyncInstantiateOperation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            public static partial nint INTERNAL_INSTANTIATE_ASYNC_WITH_PARAMS(nint original, System.Int32 count, UnityEngine.InstantiateParameters parameters, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation Internal_InstantiateAsyncWithParams_Injected(UnityEngine.Object original, System.Int32 count, UnityEngine.InstantiateParameters& parameters, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters&</param>
            /// <param name = "positions">struct System.IntPtr</param>
            /// <param name = "positionsCount">struct System.Int32</param>
            /// <param name = "rotations">struct System.IntPtr</param>
            /// <param name = "rotationsCount">struct System.Int32</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateAsyncWithParams_Injected", "UnityEngine.AsyncInstantiateOperation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            public static partial nint INTERNAL_INSTANTIATE_ASYNC_WITH_PARAMS_INJECTED(nint original, System.Int32 count, UnityEngine.InstantiateParameters &parameters, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE(nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_INJECTED(nint data, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParams(UnityEngine.Object data, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParams", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARAMS(nint data, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParams_Injected(UnityEngine.Object data, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.InstantiateParameters& parameters)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3&</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion&</param>
            /// <param name = "parameters">struct UnityEngine.InstantiateParameters&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParams_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.InstantiateParameters&", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARAMS_INJECTED(nint data, UnityEngine.Vector3 &position, UnityEngine.Quaternion &rotation, UnityEngine.InstantiateParameters &parameters); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT(nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED(nint data, nint parent, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name = "o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsNativeObjectAlive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_NATIVE_OBJECT_ALIVE(nint o); 
*/
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPersistent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_PERSISTENT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_EQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name = "exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean OP_IMPLICIT(nint exists); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_INEQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void SET_NAME(nint obj, nint name); 
*/
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint TO_STRING(nint obj); 
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
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureRunningOnMainThread", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ENSURE_RUNNING_ON_MAIN_THREAD(); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_hideFlags", "UnityEngine.HideFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.HideFlags GET_HIDE_FLAGS(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCachedPtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.IntPtr GET_CACHED_PTR(); 
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
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInstanceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_INSTANCE_ID(); 
*/
            /// <summary>
            ///   System.Void MarkDirty()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MarkDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void MARK_DIRTY(); 
*/
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_hideFlags", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.HideFlags", 0)]
            public partial void SET_HIDE_FLAGS(UnityEngine.HideFlags value); 
*/
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
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

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Component"]
        /// </summary>
        partial struct Ptr_WinManager
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
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "parameter">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BroadcastMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SendMessageOptions", 2)]
            public partial void BROADCAST_MESSAGE(nint methodName, nint parameter, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_gameObject", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_OBJECT(); 
*/
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_transform", "UnityEngine.Transform", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TRANSFORM(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial nint GET_COMPONENT(nint type); 
*/
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentFastPath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 1)]
            public partial void GET_COMPONENT_FAST_PATH(nint type, System.IntPtr oneFurtherThanResultValue); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_CHILDREN(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENT_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_CHILDREN(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_PARENT(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENT_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Component>", 1)]
            public partial void GET_COMPONENTS(nint type, nint results); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS(nint results); 
*/
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name = "searchType">abstract class System.Type</param>
            /// <param name = "resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsForListInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void GET_COMPONENTS_FOR_LIST_INTERNAL(nint searchType, nint resultList); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive, nint result); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_CHILDREN(); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS_IN_CHILDREN(nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive, nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SendMessageOptions", 2)]
            public partial void SEND_MESSAGE(nint methodName, nint value, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Component&", 1)]
            public partial System.Boolean TRY_GET_COMPONENT(nint type, nint component); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name = "component">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            public partial System.Boolean TRY_GET_COMPONENT(nint component); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Behaviour"]
        /// </summary>
        partial struct Ptr_WinManager
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
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_enabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isActiveAndEnabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTIVE_AND_ENABLED(); 
*/
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_enabled", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_ENABLED(System.Boolean value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."MonoBehaviour"]
        /// </summary>
        partial struct Ptr_WinManager
        {
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CANCEL_INVOKE(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CancelInvokeAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial void INTERNAL_CANCEL_INVOKE_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_IsInvokingAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial System.Boolean INTERNAL_IS_INVOKING_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeDelayed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial void INVOKE_DELAYED(nint self, nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial System.Boolean IS_INVOKING(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsObjectMonoBehaviour", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_OBJECT_MONO_BEHAVIOUR(nint obj); 
*/
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name = "message">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("print", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public static partial void PRINT(nint message); 
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
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CANCEL_INVOKE(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CANCEL_INVOKE(nint methodName); 
*/
            /// <summary>
            ///   System.Threading.CancellationToken get_destroyCancellationToken()
            /// </summary>
            /// <returns>struct System.Threading.CancellationToken</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_destroyCancellationToken", "System.Threading.CancellationToken", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Threading.CancellationToken GET_DESTROY_CANCELLATION_TOKEN(); 
*/
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_useGUILayout", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_USE_GUI_LAYOUT(); 
*/
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScriptClassName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCRIPT_CLASS_NAME(); 
*/
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Invoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void INVOKE(nint methodName, System.Single time); 
*/
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeRepeating", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void INVOKE_REPEATING(nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_INVOKING(); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_INVOKING(nint methodName); 
*/
            /// <summary>
            ///   System.Void OnCancellationTokenCreated()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCancellationTokenCreated", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_CANCELLATION_TOKEN_CREATED(); 
*/
            /// <summary>
            ///   System.Void RaiseCancellation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RaiseCancellation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RAISE_CANCELLATION(); 
*/
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_useGUILayout", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_USE_GUI_LAYOUT(System.Boolean value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint START_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine_Auto", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_AUTO(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE_MANAGED(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name = "enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged2", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_MANAGED2(nint enumerator); 
*/
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopAllCoroutines", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void STOP_ALL_COROUTINES(); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void STOP_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineFromEnumeratorManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE_MANAGED(nint routine); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseMonoManager`1"]
        /// </summary>
        partial struct Ptr_WinManager
        {
            /// <summary>
            /// static  CYLProject.WinManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.WinManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.WinManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveManager"]
    /// [BaseManager<CYLProject.GameSaveManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameSaveManager>, Ptr_GameSaveManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "GameSaveManager", "CYLProject.GameSaveManager")]
    public partial class GameSaveManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameSaveManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameSaveManager(System.IntPtr ptr) => new Ptr_GameSaveManager(ptr);
            public static implicit operator System.IntPtr(Ptr_GameSaveManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GameSaveManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveManager"]
        /// </summary>
        partial struct Ptr_GameSaveManager
        {
            /// <summary>
            /// 0x0 System.Int32 ManualSaveSlotCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 MANUAL_SAVE_SLOT_COUNT = 99; 
*/
            /// <summary>
            /// 0x0 System.Int32 AutoSaveSlotCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 AUTO_SAVE_SLOT_COUNT = 5; 
*/
            /// <summary>
            /// 0x0 System.String GameConfigPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint GAME_CONFIG_PATH = Config; 
*/
            /// <summary>
            /// 0x0 System.String AutoSaveName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint AUTO_SAVE_NAME = GameSave_Auto_; 
*/
            /// <summary>
            /// 0x0 System.String ManualSaveName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint MANUAL_SAVE_NAME = GameSave_Manual_; 
*/
            /// <summary>
            /// 0x0 System.String RuntimeSaveName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint RUNTIME_SAVE_NAME = GameSave_Runtime; 
*/
            /// <summary>
            /// 0x0 System.String FileType
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint FILE_TYPE = .save; 
*/
            /// <summary>
            /// 0x0 System.Single AutoSaveInterval
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single AUTO_SAVE_INTERVAL = 1; 
*/
            /// <summary>
            /// 0x0 CYLProject.GameSaveManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveManager"]
            /// </summary>
            /// <returns>class CYLProject.GameSaveManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.GameSaveManager")]
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
            /// 0x18 System.String _gameConfigPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_gameConfigPath", "System.String")]
            public partial nint _GAME_CONFIG_PATH { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String _runtimeSavePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_runtimeSavePath", "System.String")]
            public partial nint _RUNTIME_SAVE_PATH { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.Int32 , CYLProject.GameSaveShortInfo> _manualSaveSInfoDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , CYLProject.GameSaveShortInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_manualSaveSInfoDict", "System.Collections.Generic.Dictionary<System.Int32,CYLProject.GameSaveShortInfo>")]
            public partial nint _MANUAL_SAVE_S_INFO_DICT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<CYLProject.GameSaveShortInfo> _autoSaveSInfoList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<CYLProject.GameSaveShortInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_autoSaveSInfoList", "System.Collections.Generic.List<CYLProject.GameSaveShortInfo>")]
            public partial nint _AUTO_SAVE_S_INFO_LIST { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Threading.CancellationTokenSource _runtimeSaveCTS
            /// class ["mscorlib.dll"."System.Threading"."CancellationTokenSource"]
            /// </summary>
            /// <returns>class System.Threading.CancellationTokenSource</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_runtimeSaveCTS", "System.Threading.CancellationTokenSource")]
            public partial nint _RUNTIME_SAVE_CTS { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Threading.CancellationTokenSource _gameConfigSaveCTS
            /// class ["mscorlib.dll"."System.Threading"."CancellationTokenSource"]
            /// </summary>
            /// <returns>class System.Threading.CancellationTokenSource</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_gameConfigSaveCTS", "System.Threading.CancellationTokenSource")]
            public partial nint _GAME_CONFIG_SAVE_CTS { get; set; } 
*/

            /// <summary>
            /// 0x48 Cysharp.Threading.Tasks.UniTask _gameConfigSaveTask
            /// struct ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTask"]
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_gameConfigSaveTask", "Cysharp.Threading.Tasks.UniTask")]
            public partial Cysharp.Threading.Tasks.UniTask _GAME_CONFIG_SAVE_TASK { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Boolean forceRuntimeSave
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceRuntimeSave", "System.Boolean")]
            public partial System.Boolean FORCE_RUNTIME_SAVE { get; set; } 
*/

            /// <summary>
            /// 0x60 System.DateTime _playTimeCahce
            /// struct ["mscorlib.dll"."System"."DateTime"]
            /// </summary>
            /// <returns>struct System.DateTime</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_playTimeCahce", "System.DateTime")]
            public partial System.DateTime _PLAY_TIME_CAHCE { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String _version
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.String")]
            public partial nint _VERSION { get; set; } 
*/

            /// <summary>
            /// 0x70 CYLProject.GameSaveUpdateManager _saveUpdateMgr
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveUpdateManager"]
            /// </summary>
            /// <returns>class CYLProject.GameSaveUpdateManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_saveUpdateMgr", "CYLProject.GameSaveUpdateManager")]
            public partial nint _SAVE_UPDATE_MGR { get; set; } 
*/

            /// <summary>
            /// 0x78 Newtonsoft.Json.Converters.StringEnumConverter _enumConverter
            /// class ["Newtonsoft.Json.dll"."Newtonsoft.Json.Converters"."StringEnumConverter"]
            /// </summary>
            /// <returns>class Newtonsoft.Json.Converters.StringEnumConverter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_enumConverter", "Newtonsoft.Json.Converters.StringEnumConverter")]
            public partial nint _ENUM_CONVERTER { get; set; } 
*/

            /// <summary>
            /// 0x80 CYLProject.GameSaveData <GameSaveData>k__BackingField
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveData"]
            /// </summary>
            /// <returns>class CYLProject.GameSaveData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<GameSaveData>k__BackingField", "CYLProject.GameSaveData")]
            public partial nint GAME_SAVE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x88 CYLProject.GameConfigSave <GameConfigSave>k__BackingField
            /// class ["Assembly-CSharp.dll"."CYLProject"."GameConfigSave"]
            /// </summary>
            /// <returns>class CYLProject.GameConfigSave</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<GameConfigSave>k__BackingField", "CYLProject.GameConfigSave")]
            public partial nint GAME_CONFIG_SAVE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."GameSaveManager"]
        /// </summary>
        partial struct Ptr_GameSaveManager
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
            ///   System.Void <LoadRuntimeSave>b__25_0()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<LoadRuntimeSave>b__25_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_RUNTIME_SAVEB__25_0(); 
*/
            /// <summary>
            ///   System.Void AddRecordValue(CYLProject.PlayerRecordType recordType, System.UInt32 addValue)
            /// </summary>
            /// <param name = "recordType">enum CYLProject.PlayerRecordType</param>
            /// <param name = "addValue">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRecordValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.PlayerRecordType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 1)]
            public partial void ADD_RECORD_VALUE(CYLProject.PlayerRecordType recordType, System.UInt32 addValue); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> AutoSave(UnityEngine.Texture2D screenShot)
            /// </summary>
            /// <param name = "screenShot">class UnityEngine.Texture2D</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSave", "Cysharp.Threading.Tasks.UniTask<System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Texture2D", 0)]
            public partial Cysharp.Threading.Tasks.UniTask<System.Boolean> AUTO_SAVE(nint screenShot); 
*/
            /// <summary>
            ///   System.Void AutoSaveGame(System.Byte[] texturnData)
            /// </summary>
            /// <param name = "texturnData">class System.Byte[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSaveGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
            public partial void AUTO_SAVE_GAME(nint texturnData); 
*/
            /// <summary>
            ///   System.Void AutoSaveRuntime(System.String jsonStr)
            /// </summary>
            /// <param name = "jsonStr">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSaveRuntime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void AUTO_SAVE_RUNTIME(nint jsonStr); 
*/
            /// <summary>
            ///   System.Void ChangeGameSaveData(CYLProject.GameSaveData newSave)
            /// </summary>
            /// <param name = "newSave">class CYLProject.GameSaveData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeGameSaveData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveData", 0)]
            public partial void CHANGE_GAME_SAVE_DATA(nint newSave); 
*/
            /// <summary>
            ///   System.Void CheckGameSavePath()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckGameSavePath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_GAME_SAVE_PATH(); 
*/
            /// <summary>
            ///   System.Void CreateNewSave(System.Int32 difficulty, System.String firstName, System.String lastName, System.Single[] attributeList, System.Collections.Generic.List<System.String> personalityIds)
            /// </summary>
            /// <param name = "difficulty">struct System.Int32</param>
            /// <param name = "firstName">class System.String</param>
            /// <param name = "lastName">class System.String</param>
            /// <param name = "attributeList">class System.Single[]</param>
            /// <param name = "personalityIds">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateNewSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 4)]
            public partial void CREATE_NEW_SAVE(System.Int32 difficulty, nint firstName, nint lastName, nint attributeList, nint personalityIds); 
*/
            /// <summary>
            ///   System.Boolean DeleteSave(System.Int32 idx)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSave", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean DELETE_SAVE(System.Int32 idx); 
*/
            /// <summary>
            ///   System.Boolean DeleteSave(CYLProject.GameSaveType type, System.Int32 idx)
            /// </summary>
            /// <param name = "type">enum CYLProject.GameSaveType</param>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSave", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean DELETE_SAVE(CYLProject.GameSaveType type, System.Int32 idx); 
*/
            /// <summary>
            ///   CYLProject.GameConfigSave get_GameConfigSave()
            /// </summary>
            /// <returns>class CYLProject.GameConfigSave</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GameConfigSave", "CYLProject.GameConfigSave", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_CONFIG_SAVE(); 
*/
            /// <summary>
            ///   CYLProject.GameSaveData get_GameSaveData()
            /// </summary>
            /// <returns>class CYLProject.GameSaveData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GameSaveData", "CYLProject.GameSaveData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_SAVE_DATA(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , CYLProject.GameSaveShortInfo> get_ManualSaveSInfoDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , CYLProject.GameSaveShortInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ManualSaveSInfoDict", "System.Collections.Generic.Dictionary<System.Int32,CYLProject.GameSaveShortInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MANUAL_SAVE_S_INFO_DICT(); 
*/
            /// <summary>
            ///   System.Boolean GetIsCanLoad()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetIsCanLoad", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_CAN_LOAD(); 
*/
            /// <summary>
            ///   System.Boolean GetIsCanLoadImmediately()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetIsCanLoadImmediately", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_CAN_LOAD_IMMEDIATELY(); 
*/
            /// <summary>
            ///   System.String GetSavePath(CYLProject.GameSaveType type)
            /// </summary>
            /// <param name = "type">enum CYLProject.GameSaveType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSavePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveType", 0)]
            public partial nint GET_SAVE_PATH(CYLProject.GameSaveType type); 
*/
            /// <summary>
            ///   System.String GetSaveTypePath(CYLProject.GameSaveType type)
            /// </summary>
            /// <param name = "type">enum CYLProject.GameSaveType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveTypePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveType", 0)]
            public partial nint GET_SAVE_TYPE_PATH(CYLProject.GameSaveType type); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> Load(CYLProject.GameSaveType type, System.Int32 idx)
            /// </summary>
            /// <param name = "type">enum CYLProject.GameSaveType</param>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "Cysharp.Threading.Tasks.UniTask<System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<System.Boolean> LOAD(CYLProject.GameSaveType type, System.Int32 idx); 
*/
            /// <summary>
            ///   System.Void LoadGame(CYLProject.GameSaveType type, System.Int32 idx)
            /// </summary>
            /// <param name = "type">enum CYLProject.GameSaveType</param>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void LOAD_GAME(CYLProject.GameSaveType type, System.Int32 idx); 
*/
            /// <summary>
            ///   System.Void LoadGameConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadGameConfig", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_GAME_CONFIG(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> LoadGameSaveMenu()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadGameSaveMenu", "Cysharp.Threading.Tasks.UniTask<System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask<System.Boolean> LOAD_GAME_SAVE_MENU(); 
*/
            /// <summary>
            ///   T LoadJson(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadJson", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD_JSON(nint path); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<CYLProject.GameSaveData> LoadManualSaveData(System.Int32 idx, System.Threading.CancellationTokenSource cts)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <param name = "cts">class System.Threading.CancellationTokenSource</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<CYLProject.GameSaveData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadManualSaveData", "Cysharp.Threading.Tasks.UniTask<CYLProject.GameSaveData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationTokenSource", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<CYLProject.GameSaveData> LOAD_MANUAL_SAVE_DATA(System.Int32 idx, nint cts); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> LoadRuntimeSave()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadRuntimeSave", "Cysharp.Threading.Tasks.UniTask<System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask<System.Boolean> LOAD_RUNTIME_SAVE(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Byte [ ]> LoadScreenShotBytes(System.String path, System.Threading.CancellationToken token)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "token">struct System.Threading.CancellationToken</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Byte [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadScreenShotBytes", "Cysharp.Threading.Tasks.UniTask<System.Byte[]>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.CancellationToken", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<System.Byte[]> LOAD_SCREEN_SHOT_BYTES(nint path, System.Threading.CancellationToken token); 
*/
            /// <summary>
            ///   System.Byte[] LoadScreenShotBytes(System.String path)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <returns>class System.Byte[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadScreenShotBytes", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint LOAD_SCREEN_SHOT_BYTES(nint path); 
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
            ///   System.Void OnMissionChanged()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnMissionChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_MISSION_CHANGED(); 
*/
            /// <summary>
            ///   System.Void ReplaceRecordValue(CYLProject.PlayerRecordType recordType, System.UInt32 value)
            /// </summary>
            /// <param name = "recordType">enum CYLProject.PlayerRecordType</param>
            /// <param name = "value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReplaceRecordValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.PlayerRecordType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 1)]
            public partial void REPLACE_RECORD_VALUE(CYLProject.PlayerRecordType recordType, System.UInt32 value); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask RuntimeSaveAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RuntimeSaveAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask RUNTIME_SAVE_ASYNC(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask<System.Boolean> Save(System.Int32 idx, System.Byte[] texturnData)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <param name = "texturnData">class System.Byte[]</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Save", "Cysharp.Threading.Tasks.UniTask<System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 1)]
            public partial Cysharp.Threading.Tasks.UniTask<System.Boolean> SAVE(System.Int32 idx, nint texturnData); 
*/
            /// <summary>
            ///   System.Void SaveGame(System.Int32 idx, System.Byte[] texturnData)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <param name = "texturnData">class System.Byte[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 1)]
            public partial void SAVE_GAME(System.Int32 idx, nint texturnData); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTask SaveGameConfig()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveGameConfig", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTask SAVE_GAME_CONFIG(); 
*/
            /// <summary>
            ///   System.Void SaveJson(System.String json, System.String path)
            /// </summary>
            /// <param name = "json">class System.String</param>
            /// <param name = "path">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveJson", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void SAVE_JSON(nint json, nint path); 
*/
            /// <summary>
            ///   System.String SaveToJson(System.Object save)
            /// </summary>
            /// <param name = "save">class System.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveToJson", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial nint SAVE_TO_JSON(nint save); 
*/
            /// <summary>
            ///   System.Void set_GameConfigSave(CYLProject.GameConfigSave value)
            /// </summary>
            /// <param name = "value">class CYLProject.GameConfigSave</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_GameConfigSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameConfigSave", 0)]
            public partial void SET_GAME_CONFIG_SAVE(nint value); 
*/
            /// <summary>
            ///   System.Void set_GameSaveData(CYLProject.GameSaveData value)
            /// </summary>
            /// <param name = "value">class CYLProject.GameSaveData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_GameSaveData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveData", 0)]
            public partial void SET_GAME_SAVE_DATA(nint value); 
*/
            /// <summary>
            ///   System.Void UpdateRunTimeSave()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateRunTimeSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_RUN_TIME_SAVE(); 
*/
            /// <summary>
            ///   System.Void UpdateRunTimeSaveNow()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateRunTimeSaveNow", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_RUN_TIME_SAVE_NOW(); 
*/
            /// <summary>
            ///   System.Void WriteShortSave(CYLProject.GameSaveShortInfo shortInfo)
            /// </summary>
            /// <param name = "shortInfo">class CYLProject.GameSaveShortInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WriteShortSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.GameSaveShortInfo", 0)]
            public partial void WRITE_SHORT_SAVE(nint shortInfo); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_GameSaveManager
        {
            /// <summary>
            /// static  CYLProject.GameSaveManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.GameSaveManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.GameSaveManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
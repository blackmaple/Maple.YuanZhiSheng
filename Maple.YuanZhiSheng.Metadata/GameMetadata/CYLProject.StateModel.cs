namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."StateModel"]
    /// [CYLProject.BaseModel]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_StateModel>, Ptr_StateModel>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "StateModel", "CYLProject.StateModel")]
    public partial class StateModel
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_StateModel(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_StateModel(System.IntPtr ptr) => new Ptr_StateModel(ptr);
            public static implicit operator System.IntPtr(Ptr_StateModel ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_StateModel ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."StateModel"]
        /// </summary>
        partial struct Ptr_StateModel
        {
            /// <summary>
            /// 0x10 CYLProject.StateSave _stateSave
            /// class ["Assembly-CSharp.dll"."CYLProject"."StateSave"]
            /// </summary>
            /// <returns>class CYLProject.StateSave</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_stateSave", "CYLProject.StateSave")]
            public partial nint _STATE_SAVE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<DB.CalendarData> _calendarDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DB.CalendarData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_calendarDatas", "System.Collections.Generic.List<DB.CalendarData>")]
            public partial nint _CALENDAR_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.HashSet<System.Int32> _conditionDirty
            /// class ["System.Core.dll"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_conditionDirty", "System.Collections.Generic.HashSet<System.Int32>")]
            public partial nint _CONDITION_DIRTY { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.Int32> _lastDirtyConditionList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lastDirtyConditionList", "System.Collections.Generic.List<System.Int32>")]
            public partial nint _LAST_DIRTY_CONDITION_LIST { get; set; } 
*/

            /// <summary>
            /// 0x30 ObjectPool<CYLProject.Condition> _conditionPool
            /// class ["Assembly-CSharp.dll".""."ObjectPool`1"]
            /// </summary>
            /// <returns>class ObjectPool<CYLProject.Condition></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_conditionPool", "ObjectPool<CYLProject.Condition>")]
            public partial nint _CONDITION_POOL { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.Int32 , CYLProject.Condition> _conditionDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , CYLProject.Condition></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_conditionDict", "System.Collections.Generic.Dictionary<System.Int32,CYLProject.Condition>")]
            public partial nint _CONDITION_DICT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<System.Int32> _removeConditionList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_removeConditionList", "System.Collections.Generic.List<System.Int32>")]
            public partial nint _REMOVE_CONDITION_LIST { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<System.String , System.Boolean> _kpiNeedPost
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_kpiNeedPost", "System.Collections.Generic.Dictionary<System.String,System.Boolean>")]
            public partial nint _KPI_NEED_POST { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."StateModel"]
        /// </summary>
        partial struct Ptr_StateModel
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
            ///   System.Void AddCalendar()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddCalendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ADD_CALENDAR(); 
*/
            /// <summary>
            ///   System.Void AddGameMission(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddGameMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_GAME_MISSION(nint id); 
*/
            /// <summary>
            ///   System.Void AddMapEvent(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddMapEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_MAP_EVENT(nint eventId); 
*/
            /// <summary>
            ///   System.Void AddMissionObjective(System.Int32 missionId, CYLProject.MissionInfo info)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <param name = "info">class CYLProject.MissionInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddMissionObjective", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.MissionInfo", 1)]
            public partial void ADD_MISSION_OBJECTIVE(System.Int32 missionId, nint info); 
*/
            /// <summary>
            ///   System.Void BreakNewFlag(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BreakNewFlag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void BREAK_NEW_FLAG(nint id); 
*/
            /// <summary>
            ///   System.Void CancelDelegation(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelDelegation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CANCEL_DELEGATION(nint delegationId); 
*/
            /// <summary>
            ///   System.Void CheckBattleSkillUnlock(System.Boolean checkAll)
            /// </summary>
            /// <param name = "checkAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckBattleSkillUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_BATTLE_SKILL_UNLOCK(System.Boolean checkAll); 
*/
            /// <summary>
            ///   System.Void CheckConditions(System.Boolean restart)
            /// </summary>
            /// <param name = "restart">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckConditions", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_CONDITIONS(System.Boolean restart); 
*/
            /// <summary>
            ///   System.Void CheckDelegationPool()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckDelegationPool", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_DELEGATION_POOL(); 
*/
            /// <summary>
            ///   System.Void CheckGameMissionCompleted(System.Boolean checkAll)
            /// </summary>
            /// <param name = "checkAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckGameMissionCompleted", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_GAME_MISSION_COMPLETED(System.Boolean checkAll); 
*/
            /// <summary>
            ///   System.Void CheckGameMissionSend()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckGameMissionSend", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_GAME_MISSION_SEND(); 
*/
            /// <summary>
            ///   System.Void CheckMapEventPool()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckMapEventPool", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_MAP_EVENT_POOL(); 
*/
            /// <summary>
            ///   System.Void CheckNewDelegations()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNewDelegations", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_NEW_DELEGATIONS(); 
*/
            /// <summary>
            ///   System.Void CheckRemoveGameMission()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckRemoveGameMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_REMOVE_GAME_MISSION(); 
*/
            /// <summary>
            ///   System.Void CheckRemoveLetter()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckRemoveLetter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_REMOVE_LETTER(); 
*/
            /// <summary>
            ///   System.Void CheckStudyCateUnlock(System.Boolean checkAll)
            /// </summary>
            /// <param name = "checkAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckStudyCateUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_STUDY_CATE_UNLOCK(System.Boolean checkAll); 
*/
            /// <summary>
            ///   System.Void CheckSystemUnlock(System.Boolean checkAll)
            /// </summary>
            /// <param name = "checkAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckSystemUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_SYSTEM_UNLOCK(System.Boolean checkAll); 
*/
            /// <summary>
            ///   System.Void ClaimDelegation(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimDelegation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLAIM_DELEGATION(nint delegationId); 
*/
            /// <summary>
            ///   System.Boolean ClaimGameMissionRewards(System.String id, System.Boolean tipAudio)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "tipAudio">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimGameMissionRewards", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean CLAIM_GAME_MISSION_REWARDS(nint id, System.Boolean tipAudio); 
*/
            /// <summary>
            ///   System.Void ClaimLetter(System.String letterId)
            /// </summary>
            /// <param name = "letterId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimLetter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLAIM_LETTER(nint letterId); 
*/
            /// <summary>
            ///   System.Void CompleteDelegation(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompleteDelegation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void COMPLETE_DELEGATION(nint delegationId); 
*/
            /// <summary>
            ///   System.Void CompleteGameEvent(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompleteGameEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void COMPLETE_GAME_EVENT(nint eventId); 
*/
            /// <summary>
            ///   System.Void CompleteMapEvent(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompleteMapEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void COMPLETE_MAP_EVENT(nint eventId); 
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
            ///   System.String get_CalendarId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CalendarId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CALENDAR_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_CalendarIdx()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CalendarIdx", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_CALENDAR_IDX(); 
*/
            /// <summary>
            ///   System.Collections.Generic.HashSet<System.Int32> get_ConditionDirty()
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ConditionDirty", "System.Collections.Generic.HashSet<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONDITION_DIRTY(); 
*/
            /// <summary>
            ///   System.String get_MapTwoId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MapTwoId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAP_TWO_ID(); 
*/
            /// <summary>
            ///   System.Int32 get_RoomRestCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoomRestCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ROOM_REST_COUNT(); 
*/
            /// <summary>
            ///   System.Boolean get_StoryNextOption()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoryNextOption", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_STORY_NEXT_OPTION(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Int32 , System.Int32> get_StoryNodeStateDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoryNodeStateDict", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STORY_NODE_STATE_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetAllGameMissions()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllGameMissions", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ALL_GAME_MISSIONS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetAllLetters()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllLetters", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ALL_LETTERS(); 
*/
            /// <summary>
            ///   System.Boolean GetAlreadyShowManual(System.String manualId)
            /// </summary>
            /// <param name = "manualId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAlreadyShowManual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_ALREADY_SHOW_MANUAL(nint manualId); 
*/
            /// <summary>
            ///   System.Boolean GetBattleSkillIsUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleSkillIsUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_BATTLE_SKILL_IS_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Boolean GetConditonEnough(System.Int32[] missionIds)
            /// </summary>
            /// <param name = "missionIds">class System.Int32[]</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetConditonEnough", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial System.Boolean GET_CONDITON_ENOUGH(nint missionIds); 
*/
            /// <summary>
            ///   System.ValueTuple<System.String , System.Int32> GetCurrentStory()
            /// </summary>
            /// <returns>struct System.ValueTuple<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCurrentStory", "System.ValueTuple<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.ValueTuple<System.String, System.Int32> GET_CURRENT_STORY(); 
*/
            /// <summary>
            ///   CYLProject.CalendarState GetDayState()
            /// </summary>
            /// <returns>enum CYLProject.CalendarState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDayState", "CYLProject.CalendarState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial CYLProject.CalendarState GET_DAY_STATE(); 
*/
            /// <summary>
            ///   System.Boolean GetDelegationClaimed(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDelegationClaimed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_DELEGATION_CLAIMED(nint delegationId); 
*/
            /// <summary>
            ///   System.Boolean GetDelegationIsCompleted(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDelegationIsCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_DELEGATION_IS_COMPLETED(nint delegationId); 
*/
            /// <summary>
            ///   System.Int32 GetEnergyCap()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnergyCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ENERGY_CAP(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetFollowGameMissions()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFollowGameMissions", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FOLLOW_GAME_MISSIONS(); 
*/
            /// <summary>
            ///   System.Boolean GetGameEventIsCompleted(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameEventIsCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_GAME_EVENT_IS_COMPLETED(nint eventId); 
*/
            /// <summary>
            ///   System.Int32 GetGameMissionCalendar(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameMissionCalendar", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_GAME_MISSION_CALENDAR(nint id); 
*/
            /// <summary>
            ///   MissionState GetGameMissionState(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>enum MissionState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameMissionState", "MissionState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial MissionState GET_GAME_MISSION_STATE(nint id); 
*/
            /// <summary>
            ///   System.Boolean GetIsFollowGameMission(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetIsFollowGameMission", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_IS_FOLLOW_GAME_MISSION(nint id); 
*/
            /// <summary>
            ///   System.Boolean GetIsTeenager()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetIsTeenager", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_TEENAGER(); 
*/
            /// <summary>
            ///   System.Int32 GetLetterCalendar(System.String letterId)
            /// </summary>
            /// <param name = "letterId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLetterCalendar", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_LETTER_CALENDAR(nint letterId); 
*/
            /// <summary>
            ///   System.Boolean GetMapEventIsCompleted(DB.MapEventData eventData)
            /// </summary>
            /// <param name = "eventData">class DB.MapEventData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapEventIsCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.MapEventData", 0)]
            public partial System.Boolean GET_MAP_EVENT_IS_COMPLETED(nint eventData); 
*/
            /// <summary>
            ///   System.Boolean GetMapEventIsCompleted(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapEventIsCompleted", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_MAP_EVENT_IS_COMPLETED(nint eventId); 
*/
            /// <summary>
            ///   System.Boolean GetMapEventIsReay(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapEventIsReay", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_MAP_EVENT_IS_REAY(nint eventId); 
*/
            /// <summary>
            ///   System.Boolean GetMapEventIsReay(DB.MapEventData eventData)
            /// </summary>
            /// <param name = "eventData">class DB.MapEventData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapEventIsReay", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.MapEventData", 0)]
            public partial System.Boolean GET_MAP_EVENT_IS_REAY(nint eventData); 
*/
            /// <summary>
            ///   System.Boolean GetMapEventIsTrigger(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMapEventIsTrigger", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_MAP_EVENT_IS_TRIGGER(nint eventId); 
*/
            /// <summary>
            ///   CYLProject.MissionInfo GetMissionInfo(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>class CYLProject.MissionInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissionInfo", "CYLProject.MissionInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_MISSION_INFO(System.Int32 missionId); 
*/
            /// <summary>
            ///   MissionState GetMissionState(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>enum MissionState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissionState", "MissionState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial MissionState GET_MISSION_STATE(System.Int32 missionId); 
*/
            /// <summary>
            ///   System.Boolean GetNewFlag(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNewFlag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_NEW_FLAG(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetRestFollowGameMission()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRestFollowGameMission", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_REST_FOLLOW_GAME_MISSION(); 
*/
            /// <summary>
            ///   System.Boolean GetStudyCateIsUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyCateIsUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_STUDY_CATE_IS_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Boolean GetStudyIsUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyIsUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_STUDY_IS_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Boolean GetSystemIsUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSystemIsUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_SYSTEM_IS_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Void GMGoCalendar(System.Int32 idx)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GMGoCalendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void GM_GO_CALENDAR(System.Int32 idx); 
*/
            /// <summary>
            ///   System.Void GoCalendar(DB.CalendarData cdata)
            /// </summary>
            /// <param name = "cdata">class DB.CalendarData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GoCalendar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.CalendarData", 0)]
            public partial void GO_CALENDAR(nint cdata); 
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
            ///   System.Void OnGameMissionCompleted(DB.GameMissionData gmdata)
            /// </summary>
            /// <param name = "gmdata">class DB.GameMissionData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnGameMissionCompleted", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.GameMissionData", 0)]
            public partial void ON_GAME_MISSION_COMPLETED(nint gmdata); 
*/
            /// <summary>
            ///   System.Void OnMissionStateChanged(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnMissionStateChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ON_MISSION_STATE_CHANGED(System.Int32 missionId); 
*/
            /// <summary>
            ///   System.Void PostEvent(System.String kpi, System.Int32 value, System.String[] ids)
            /// </summary>
            /// <param name = "kpi">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "ids">class System.String[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PostEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String[]", 2)]
            public partial void POST_EVENT(nint kpi, System.Int32 value, nint ids); 
*/
            /// <summary>
            ///   System.Void RecycleCondition(CYLProject.Condition c)
            /// </summary>
            /// <param name = "c">class CYLProject.Condition</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecycleCondition", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.Condition", 0)]
            public partial void RECYCLE_CONDITION(nint c); 
*/
            /// <summary>
            ///   System.Void RemoveGameMission(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveGameMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_GAME_MISSION(nint id); 
*/
            /// <summary>
            ///   System.Void RemoveLetter(System.String letterId)
            /// </summary>
            /// <param name = "letterId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveLetter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_LETTER(nint letterId); 
*/
            /// <summary>
            ///   System.Void RemoveMapEvent(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveMapEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_MAP_EVENT(nint eventId); 
*/
            /// <summary>
            ///   CYLProject.Condition RequestCondition()
            /// </summary>
            /// <returns>class CYLProject.Condition</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RequestCondition", "CYLProject.Condition", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint REQUEST_CONDITION(); 
*/
            /// <summary>
            ///   System.Void ResetDelegation(System.String delegationId)
            /// </summary>
            /// <param name = "delegationId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetDelegation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RESET_DELEGATION(nint delegationId); 
*/
            /// <summary>
            ///   System.Void ResetMapEvent(System.String eventId)
            /// </summary>
            /// <param name = "eventId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetMapEvent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RESET_MAP_EVENT(nint eventId); 
*/
            /// <summary>
            ///   System.Void ResetMission(System.Int32[] missionIds)
            /// </summary>
            /// <param name = "missionIds">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial void RESET_MISSION(nint missionIds); 
*/
            /// <summary>
            ///   System.Void ResetMission(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void RESET_MISSION(System.Int32 missionId); 
*/
            /// <summary>
            ///   System.Void RoomRest()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RoomRest", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ROOM_REST(); 
*/
            /// <summary>
            ///   System.Void SaveCurrentMap(System.String mapTwoId)
            /// </summary>
            /// <param name = "mapTwoId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveCurrentMap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SAVE_CURRENT_MAP(nint mapTwoId); 
*/
            /// <summary>
            ///   System.Void SaveMonthSummaryAttribute()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveMonthSummaryAttribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_MONTH_SUMMARY_ATTRIBUTE(); 
*/
            /// <summary>
            ///   System.Void SaveStoryState(System.String storyId, System.Int32 nodeId, System.Int32 arg, System.Boolean nextOption)
            /// </summary>
            /// <param name = "storyId">class System.String</param>
            /// <param name = "nodeId">struct System.Int32</param>
            /// <param name = "arg">struct System.Int32</param>
            /// <param name = "nextOption">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveStoryState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void SAVE_STORY_STATE(nint storyId, System.Int32 nodeId, System.Int32 arg, System.Boolean nextOption); 
*/
            /// <summary>
            ///   System.Void SendLetter(System.String letterId)
            /// </summary>
            /// <param name = "letterId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendLetter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SEND_LETTER(nint letterId); 
*/
            /// <summary>
            ///   System.Void SetAlreadyShowManual(System.String manualId)
            /// </summary>
            /// <param name = "manualId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAlreadyShowManual", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ALREADY_SHOW_MANUAL(nint manualId); 
*/
            /// <summary>
            ///   System.Void SetBattleSkillUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBattleSkillUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_BATTLE_SKILL_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Void SetDateState(CYLProject.CalendarState state)
            /// </summary>
            /// <param name = "state">enum CYLProject.CalendarState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetDateState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.CalendarState", 0)]
            public partial void SET_DATE_STATE(CYLProject.CalendarState state); 
*/
            /// <summary>
            ///   System.Void SetGameMissionComplete(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetGameMissionComplete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_GAME_MISSION_COMPLETE(nint id); 
*/
            /// <summary>
            ///   System.Void SetNewFlag(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNewFlag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NEW_FLAG(nint id); 
*/
            /// <summary>
            ///   System.Void SetStoryComplete(System.String storyId)
            /// </summary>
            /// <param name = "storyId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetStoryComplete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_STORY_COMPLETE(nint storyId); 
*/
            /// <summary>
            ///   System.Void SetStudyCateUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetStudyCateUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_STUDY_CATE_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Void SetStudyUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetStudyUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_STUDY_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Void SetSystemUnlock(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSystemUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_SYSTEM_UNLOCK(nint id); 
*/
            /// <summary>
            ///   System.Void StartFollowGameMission(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartFollowGameMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void START_FOLLOW_GAME_MISSION(nint id); 
*/
            /// <summary>
            ///   System.Void StopFollowGameMission(System.String id, System.Boolean force)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "force">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopFollowGameMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void STOP_FOLLOW_GAME_MISSION(nint id, System.Boolean force); 
*/
            /// <summary>
            ///   System.Void UnlockMission(System.Int32[] missionIds)
            /// </summary>
            /// <param name = "missionIds">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public partial void UNLOCK_MISSION(nint missionIds); 
*/
            /// <summary>
            ///   System.Void UnlockMission(System.Int32 missionId)
            /// </summary>
            /// <param name = "missionId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockMission", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UNLOCK_MISSION(System.Int32 missionId); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."CYLProject"."BaseModel"]
        /// </summary>
        partial struct Ptr_StateModel
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
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Void Init()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT(); 
*/
        }
    }
}
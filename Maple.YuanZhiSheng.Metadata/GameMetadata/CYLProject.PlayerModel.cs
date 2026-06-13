namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerModel"]
    /// [CYLProject.BaseModel]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerModel>, Ptr_PlayerModel>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "PlayerModel", "CYLProject.PlayerModel")]
    public partial class PlayerModel
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerModel(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerModel(System.IntPtr ptr) => new Ptr_PlayerModel(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerModel ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PlayerModel ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerModel"]
        /// </summary>
        partial struct Ptr_PlayerModel
        {
            /// <summary>
            /// 0x10 CYLProject.PlayerSave _playerSave
            /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerSave"]
            /// </summary>
            /// <returns>class CYLProject.PlayerSave</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_playerSave", "CYLProject.PlayerSave")]
            public partial nint _PLAYER_SAVE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<System.String , System.Single [ ]> _roleAttributesDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_roleAttributesDict", "System.Collections.Generic.Dictionary<System.String,System.Single[]>")]
            public partial nint _ROLE_ATTRIBUTES_DICT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Boolean> _roleAttributeDirtyDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_roleAttributeDirtyDict", "System.Collections.Generic.Dictionary<System.String,System.Boolean>")]
            public partial nint _ROLE_ATTRIBUTE_DIRTY_DICT { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , System.Single [ ]> _roleBAttributesDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single [ ]></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_roleBAttributesDict", "System.Collections.Generic.Dictionary<System.String,System.Single[]>")]
            public partial nint _ROLE_B_ATTRIBUTES_DICT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , System.Boolean> _roleBAttributeDirtyDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_roleBAttributeDirtyDict", "System.Collections.Generic.Dictionary<System.String,System.Boolean>")]
            public partial nint _ROLE_B_ATTRIBUTE_DIRTY_DICT { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> _developBuffLvDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_developBuffLvDict", "System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>")]
            public partial nint _DEVELOP_BUFF_LV_DICT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean _developBuffDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_developBuffDirty", "System.Boolean")]
            public partial System.Boolean _DEVELOP_BUFF_DIRTY { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<System.String> _tempStrList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_tempStrList", "System.Collections.Generic.List<System.String>")]
            public partial nint _TEMP_STR_LIST { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Single[] lastAttriArr
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastAttriArr", "System.Single[]")]
            public partial nint LAST_ATTRI_ARR { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single[] currAttriArr
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("currAttriArr", "System.Single[]")]
            public partial nint CURR_ATTRI_ARR { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single[] lastBAttriArr
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastBAttriArr", "System.Single[]")]
            public partial nint LAST_B_ATTRI_ARR { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Single[] currBAttriArr
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("currBAttriArr", "System.Single[]")]
            public partial nint CURR_B_ATTRI_ARR { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 _accEquipIdx
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_accEquipIdx", "System.Int32")]
            public partial System.Int32 _ACC_EQUIP_IDX { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerModel"]
        /// </summary>
        partial struct Ptr_PlayerModel
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
            ///   System.Void AddBattleRolesExp(System.Int32 addExp, System.String roleLimit)
            /// </summary>
            /// <param name = "addExp">struct System.Int32</param>
            /// <param name = "roleLimit">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBattleRolesExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void ADD_BATTLE_ROLES_EXP(System.Int32 addExp, nint roleLimit); 
*/
            /// <summary>
            ///   System.Void AddBuffLvLayer(System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> buffDict, System.String buffId, System.Int32 level, System.Int32 layerNum)
            /// </summary>
            /// <param name = "buffDict">class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></param>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "layerNum">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBuffLvLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void ADD_BUFF_LV_LAYER(nint buffDict, nint buffId, System.Int32 level, System.Int32 layerNum); 
*/
            /// <summary>
            ///   System.Void AddCareerExp(System.Single exp)
            /// </summary>
            /// <param name = "exp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddCareerExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void ADD_CAREER_EXP(System.Single exp); 
*/
            /// <summary>
            ///   System.Void AddPlayerAttribute(System.String id, System.Single value)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPlayerAttribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ADD_PLAYER_ATTRIBUTE(nint id, System.Single value); 
*/
            /// <summary>
            ///   System.Void AddPlayerTalentPoint(System.String talentId)
            /// </summary>
            /// <param name = "talentId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPlayerTalentPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_PLAYER_TALENT_POINT(nint talentId); 
*/
            /// <summary>
            ///   System.Void AddRoleAttribute(System.String roleId, System.String id, System.Single addValue)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "addValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRoleAttribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void ADD_ROLE_ATTRIBUTE(nint roleId, nint id, System.Single addValue); 
*/
            /// <summary>
            ///   System.Void AddRoleAttributePercent(System.String roleId, System.String id, System.Single ratio)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "ratio">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRoleAttributePercent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void ADD_ROLE_ATTRIBUTE_PERCENT(nint roleId, nint id, System.Single ratio); 
*/
            /// <summary>
            ///   System.Void AddRoleExp(System.String roleId, System.Int32 exp)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRoleExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_ROLE_EXP(nint roleId, System.Int32 exp); 
*/
            /// <summary>
            ///   System.Void AddRoleFav(System.String roleId, System.Int32 value, System.Boolean showTip)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "showTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRoleFav", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_ROLE_FAV(nint roleId, System.Int32 value, System.Boolean showTip); 
*/
            /// <summary>
            ///   System.Void AddRoleTalentPoint(System.String roleId, System.String talentId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "talentId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRoleTalentPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void ADD_ROLE_TALENT_POINT(nint roleId, nint talentId); 
*/
            /// <summary>
            ///   System.Void AddStudyProgress(System.String id, System.Single value, System.Boolean showTip)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "value">struct System.Single</param>
            /// <param name = "showTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStudyProgress", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_STUDY_PROGRESS(nint id, System.Single value, System.Boolean showTip); 
*/
            /// <summary>
            ///   System.Void ChallengePartnerEnd(System.String roleId, System.Int32 challengeStage, System.Boolean success)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "challengeStage">struct System.Int32</param>
            /// <param name = "success">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChallengePartnerEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHALLENGE_PARTNER_END(nint roleId, System.Int32 challengeStage, System.Boolean success); 
*/
            /// <summary>
            ///   System.Void ChangeActiveCareer(System.String careerId)
            /// </summary>
            /// <param name = "careerId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeActiveCareer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CHANGE_ACTIVE_CAREER(nint careerId); 
*/
            /// <summary>
            ///   System.Void CheckCareerUnlock(System.Boolean checkAll)
            /// </summary>
            /// <param name = "checkAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckCareerUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_CAREER_UNLOCK(System.Boolean checkAll); 
*/
            /// <summary>
            ///   System.Void ClaimGoal(System.String goalId)
            /// </summary>
            /// <param name = "goalId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimGoal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLAIM_GOAL(nint goalId); 
*/
            /// <summary>
            ///   System.Void ClaimGoalRewards()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimGoalRewards", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLAIM_GOAL_REWARDS(); 
*/
            /// <summary>
            ///   System.Void ClaimStoryReward(DB.StoryRewardData data)
            /// </summary>
            /// <param name = "data">class DB.StoryRewardData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimStoryReward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.StoryRewardData", 0)]
            public partial void CLAIM_STORY_REWARD(nint data); 
*/
            /// <summary>
            ///   System.Void ClaimStoryRewards(System.String rewardIds)
            /// </summary>
            /// <param name = "rewardIds">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClaimStoryRewards", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLAIM_STORY_REWARDS(nint rewardIds); 
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
            ///   System.String get_ActiveCareer()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ActiveCareer", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ACTIVE_CAREER(); 
*/
            /// <summary>
            ///   System.Single[] get_AttributeValues()
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Single> get_CareerExpDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CareerExpDict", "System.Collections.Generic.Dictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CAREER_EXP_DICT(); 
*/
            /// <summary>
            ///   System.String get_Designation()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Designation", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESIGNATION(); 
*/
            /// <summary>
            ///   System.Int32 get_Exp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Exp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_EXP(); 
*/
            /// <summary>
            ///   System.String get_GoalId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_GoalId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GOAL_ID(); 
*/
            /// <summary>
            ///   System.Single[] get_LastAttributeValues()
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LastAttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LAST_ATTRIBUTE_VALUES(); 
*/
            /// <summary>
            ///   System.Int32 get_Level()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Level", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LEVEL(); 
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
            ///   System.Int32 get_PartnerChatRest()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PartnerChatRest", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PARTNER_CHAT_REST(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> get_Personality()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Personality", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PERSONALITY(); 
*/
            /// <summary>
            ///   System.UInt32[] get_RecordValues()
            /// </summary>
            /// <returns>class System.UInt32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RecordValues", "System.UInt32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RECORD_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , CYLProject.RoleInfo> get_RoleInfoDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.RoleInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoleInfoDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.RoleInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ROLE_INFO_DICT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , CYLProject.SkillInfo> get_SkillInfoDic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.SkillInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillInfoDic", "System.Collections.Generic.Dictionary<System.String,CYLProject.SkillInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_INFO_DIC(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Int32> get_TalentPointDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TalentPointDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TALENT_POINT_DICT(); 
*/
            /// <summary>
            ///   System.Int32 GetAllWomenFavStage()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllWomenFavStage", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ALL_WOMEN_FAV_STAGE(); 
*/
            /// <summary>
            ///   System.Single GetAttributeCap(System.Int32 attributeIdx, System.Boolean mainPlayer)
            /// </summary>
            /// <param name = "attributeIdx">struct System.Int32</param>
            /// <param name = "mainPlayer">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_ATTRIBUTE_CAP(System.Int32 attributeIdx, System.Boolean mainPlayer); 
*/
            /// <summary>
            ///   System.Single GetAttributeCap(System.String attributeId, System.Boolean mainPlayer)
            /// </summary>
            /// <param name = "attributeId">class System.String</param>
            /// <param name = "mainPlayer">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_ATTRIBUTE_CAP(nint attributeId, System.Boolean mainPlayer); 
*/
            /// <summary>
            ///   System.Single GetAttributeValue(CYLProject.AttributeType type)
            /// </summary>
            /// <param name = "type">enum CYLProject.AttributeType</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.AttributeType", 0)]
            public partial System.Single GET_ATTRIBUTE_VALUE(CYLProject.AttributeType type); 
*/
            /// <summary>
            ///   System.Single GetAttributeValue(System.Int32 attributeIdx)
            /// </summary>
            /// <param name = "attributeIdx">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_ATTRIBUTE_VALUE(System.Int32 attributeIdx); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetBattleTeammates()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleTeammates", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_TEAMMATES(); 
*/
            /// <summary>
            ///   System.Single GetCareerExp(System.String careerId)
            /// </summary>
            /// <param name = "careerId">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCareerExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Single GET_CAREER_EXP(nint careerId); 
*/
            /// <summary>
            ///   System.Boolean GetCareerIsUnlock(System.String careerId)
            /// </summary>
            /// <param name = "careerId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCareerIsUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean GET_CAREER_IS_UNLOCK(nint careerId); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> GetDevelopBuffs()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDevelopBuffs", "System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEVELOP_BUFFS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.String> GetFavRoles()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFavRoles", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FAV_ROLES(); 
*/
            /// <summary>
            ///   System.Int32 GetPlayerTalentPoint(System.String talentId)
            /// </summary>
            /// <param name = "talentId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerTalentPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_PLAYER_TALENT_POINT(nint talentId); 
*/
            /// <summary>
            ///   System.Int32 GetPlayerTalentRestPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerTalentRestPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_PLAYER_TALENT_REST_POINT(); 
*/
            /// <summary>
            ///   System.UInt32 GetRecordValue(CYLProject.PlayerRecordType type)
            /// </summary>
            /// <param name = "type">enum CYLProject.PlayerRecordType</param>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRecordValue", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.PlayerRecordType", 0)]
            public partial System.UInt32 GET_RECORD_VALUE(CYLProject.PlayerRecordType type); 
*/
            /// <summary>
            ///   System.UInt32 GetRecordValue(System.Int32 recordIdx)
            /// </summary>
            /// <param name = "recordIdx">struct System.Int32</param>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRecordValue", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.UInt32 GET_RECORD_VALUE(System.Int32 recordIdx); 
*/
            /// <summary>
            ///   System.Single[] GetRoleAttributeValues(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleAttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ROLE_ATTRIBUTE_VALUES(nint roleId); 
*/
            /// <summary>
            ///   System.Single[] GetRoleBattleAttributeValues(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleBattleAttributeValues", "System.Single[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ROLE_BATTLE_ATTRIBUTE_VALUES(nint roleId); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<DB.RoleTalentData> GetRoleBattleTalentList(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>class System.Collections.Generic.List<DB.RoleTalentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleBattleTalentList", "System.Collections.Generic.List<DB.RoleTalentData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ROLE_BATTLE_TALENT_LIST(nint roleId); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>> GetRoleBuffDict(System.String roleId, CYLProject.BuffType buffType)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "buffType">enum CYLProject.BuffType</param>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleBuffDict", "System.Collections.Generic.Dictionary<System.String,System.ValueTuple<System.Int32,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BuffType", 1)]
            public partial nint GET_ROLE_BUFF_DICT(nint roleId, CYLProject.BuffType buffType); 
*/
            /// <summary>
            ///   System.Int32 GetRoleFav(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleFav", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_ROLE_FAV(nint roleId); 
*/
            /// <summary>
            ///   CYLProject.RoleInfo GetRoleInfo(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class CYLProject.RoleInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleInfo", "CYLProject.RoleInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_ROLE_INFO(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetRoleTalentPoint(System.String talentId)
            /// </summary>
            /// <param name = "talentId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRoleTalentPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_ROLE_TALENT_POINT(nint talentId); 
*/
            /// <summary>
            ///   CYLProject.SkillInfo GetSkillInfo(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class CYLProject.SkillInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillInfo", "CYLProject.SkillInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SKILL_INFO(nint id); 
*/
            /// <summary>
            ///   DB.BattleSkillLevelData GetSkillLevelData(System.String skillId)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <returns>class DB.BattleSkillLevelData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillLevelData", "DB.BattleSkillLevelData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SKILL_LEVEL_DATA(nint skillId); 
*/
            /// <summary>
            ///   System.Single GetStudyAddProgress(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyAddProgress", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Single GET_STUDY_ADD_PROGRESS(nint id); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Single , System.Single> GetStudyProgress(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.ValueTuple<System.Single , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyProgress", "System.ValueTuple<System.Single,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.ValueTuple<System.Single, System.Single> GET_STUDY_PROGRESS(nint id); 
*/
            /// <summary>
            ///   System.Void GivePartnerGift(System.String roleId, System.String id, System.Int32 count)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GivePartnerGift", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void GIVE_PARTNER_GIFT(nint roleId, nint id, System.Int32 count); 
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
            ///   System.Void InitRoleAttributes()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitRoleAttributes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_ROLE_ATTRIBUTES(); 
*/
            /// <summary>
            ///   System.Void PartnerChat(System.String roleId, System.String chatId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "chatId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PartnerChat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void PARTNER_CHAT(nint roleId, nint chatId); 
*/
            /// <summary>
            ///   System.Void RefreshRoleAttributeValues(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshRoleAttributeValues", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REFRESH_ROLE_ATTRIBUTE_VALUES(nint roleId); 
*/
            /// <summary>
            ///   System.Void RefreshRoleBattleAttributeValues(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshRoleBattleAttributeValues", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REFRESH_ROLE_BATTLE_ATTRIBUTE_VALUES(nint roleId); 
*/
            /// <summary>
            ///   System.Void ResetRoleTalentPoint(System.String roleId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetRoleTalentPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RESET_ROLE_TALENT_POINT(nint roleId); 
*/
            /// <summary>
            ///   System.Void SelectDesignation(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SelectDesignation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SELECT_DESIGNATION(nint id); 
*/
            /// <summary>
            ///   System.Void SetCareerUnlock(System.String careerId)
            /// </summary>
            /// <param name = "careerId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCareerUnlock", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_CAREER_UNLOCK(nint careerId); 
*/
            /// <summary>
            ///   System.Void SetEquipment(System.String roleId, System.String saveId)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "saveId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetEquipment", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void SET_EQUIPMENT(nint roleId, nint saveId); 
*/
            /// <summary>
            ///   System.Void SetEquipSkill(System.String roleId, System.Int32 idx, System.String skillId, System.Boolean isEquip)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "idx">struct System.Int32</param>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "isEquip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetEquipSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void SET_EQUIP_SKILL(nint roleId, System.Int32 idx, nint skillId, System.Boolean isEquip); 
*/
            /// <summary>
            ///   System.Void SetRoleAttributesRefresh(System.String roleId, System.Boolean refreshNowTip)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "refreshNowTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRoleAttributesRefresh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_ROLE_ATTRIBUTES_REFRESH(nint roleId, System.Boolean refreshNowTip); 
*/
            /// <summary>
            ///   System.Void SetRoleInBattleTeam(System.String id, System.Boolean inTeam)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "inTeam">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRoleInBattleTeam", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_ROLE_IN_BATTLE_TEAM(nint id, System.Boolean inTeam); 
*/
            /// <summary>
            ///   System.Void SetRoleInTeam(System.String id, System.Boolean inTeam)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "inTeam">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRoleInTeam", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_ROLE_IN_TEAM(nint id, System.Boolean inTeam); 
*/
            /// <summary>
            ///   System.Void ShowEquipChangeAttriTip(System.Boolean isBAttribute, System.Single[] lastArr, System.Single[] currArr)
            /// </summary>
            /// <param name = "isBAttribute">struct System.Boolean</param>
            /// <param name = "lastArr">class System.Single[]</param>
            /// <param name = "currArr">class System.Single[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowEquipChangeAttriTip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single[]", 2)]
            public partial void SHOW_EQUIP_CHANGE_ATTRI_TIP(System.Boolean isBAttribute, nint lastArr, nint currArr); 
*/
            /// <summary>
            ///   System.Void Unequip(System.String roleId, System.Int32 slotIdx)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "slotIdx">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unequip", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UNEQUIP(nint roleId, System.Int32 slotIdx); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."CYLProject"."BaseModel"]
        /// </summary>
        partial struct Ptr_PlayerModel
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
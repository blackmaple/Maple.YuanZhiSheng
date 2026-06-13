namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."PersonalityManager"]
    /// [BaseManager<CYLProject.PersonalityManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PersonalityManager>, Ptr_PersonalityManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "PersonalityManager", "CYLProject.PersonalityManager")]
    public partial class PersonalityManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PersonalityManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PersonalityManager(System.IntPtr ptr) => new Ptr_PersonalityManager(ptr);
            public static implicit operator System.IntPtr(Ptr_PersonalityManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PersonalityManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PersonalityManager"]
        /// </summary>
        partial struct Ptr_PersonalityManager
        {
            /// <summary>
            /// 0x0 CYLProject.PersonalityManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."PersonalityManager"]
            /// </summary>
            /// <returns>class CYLProject.PersonalityManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.PersonalityManager")]
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
            /// 0x18 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.EBuffArgTypeData>> _argTypsDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.EBuffArgTypeData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_argTypsDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<CYLProject.EBuffArgTypeData>>")]
            public partial nint _ARG_TYPS_DICT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.BuffArg>> _argsDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.BuffArg>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_argsDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<CYLProject.BuffArg>>")]
            public partial nint _ARGS_DICT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PersonalityManager"]
        /// </summary>
        partial struct Ptr_PersonalityManager
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
            ///   System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.BuffArg>> get_ArgsDict()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Collections.Generic.List<CYLProject.BuffArg>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ArgsDict", "System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<CYLProject.BuffArg>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ARGS_DICT(); 
*/
            /// <summary>
            ///   System.String GetArgValue(CYLProject.EBuffArgTypeData argType, CYLProject.BuffArg arg)
            /// </summary>
            /// <param name = "argType">enum CYLProject.EBuffArgTypeData</param>
            /// <param name = "arg">struct CYLProject.BuffArg</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArgValue", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.EBuffArgTypeData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BuffArg", 1)]
            public partial nint GET_ARG_VALUE(CYLProject.EBuffArgTypeData argType, CYLProject.BuffArg arg); 
*/
            /// <summary>
            ///   System.Single GetAttributeCap(System.String attributeId)
            /// </summary>
            /// <param name = "attributeId">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Single GET_ATTRIBUTE_CAP(nint attributeId); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<CYLProject.SkillValueType , System.Single> GetBattleAdditionalDamage()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<CYLProject.SkillValueType , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleAdditionalDamage", "System.Collections.Generic.Dictionary<CYLProject.SkillValueType,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_ADDITIONAL_DAMAGE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , System.Single> GetBattleAttributeAddRatio()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBattleAttributeAddRatio", "System.Collections.Generic.Dictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BATTLE_ATTRIBUTE_ADD_RATIO(); 
*/
            /// <summary>
            ///   System.String GetDescription(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescription", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_DESCRIPTION(nint id); 
*/
            /// <summary>
            ///   System.Single GetEquipAttributeAddRatio(System.Int32 itemType)
            /// </summary>
            /// <param name = "itemType">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipAttributeAddRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_EQUIP_ATTRIBUTE_ADD_RATIO(System.Int32 itemType); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Single , System.Single> GetExAttribute(System.String attributeId, System.Boolean isStudy)
            /// </summary>
            /// <param name = "attributeId">class System.String</param>
            /// <param name = "isStudy">struct System.Boolean</param>
            /// <returns>struct System.ValueTuple<System.Single , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExAttribute", "System.ValueTuple<System.Single,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.ValueTuple<System.Single, System.Single> GET_EX_ATTRIBUTE(nint attributeId, System.Boolean isStudy); 
*/
            /// <summary>
            ///   System.Single GetGoldAddRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGoldAddRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_GOLD_ADD_RATIO(); 
*/
            /// <summary>
            ///   System.Single GetLGameAttributeAddRatio(CYLProject.LittleGameType type, System.String attributeId)
            /// </summary>
            /// <param name = "type">enum CYLProject.LittleGameType</param>
            /// <param name = "attributeId">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLGameAttributeAddRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.LittleGameType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Single GET_L_GAME_ATTRIBUTE_ADD_RATIO(CYLProject.LittleGameType type, nint attributeId); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Single , System.Int32> GetLGameMatProbabilityCount(CYLProject.LittleGameType type)
            /// </summary>
            /// <param name = "type">enum CYLProject.LittleGameType</param>
            /// <returns>struct System.ValueTuple<System.Single , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLGameMatProbabilityCount", "System.ValueTuple<System.Single,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.LittleGameType", 0)]
            public partial System.ValueTuple<System.Single, System.Int32> GET_L_GAME_MAT_PROBABILITY_COUNT(CYLProject.LittleGameType type); 
*/
            /// <summary>
            ///   System.Single GetSecretRealmAdvanceNodeAddRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSecretRealmAdvanceNodeAddRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SECRET_REALM_ADVANCE_NODE_ADD_RATIO(); 
*/
            /// <summary>
            ///   System.Single GetStudyCompleteProgress()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyCompleteProgress", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_STUDY_COMPLETE_PROGRESS(); 
*/
            /// <summary>
            ///   System.Int32 GetStudyExMoodChange(CYLProject.StudyCategory studyCate)
            /// </summary>
            /// <param name = "studyCate">enum CYLProject.StudyCategory</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStudyExMoodChange", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.StudyCategory", 0)]
            public partial System.Int32 GET_STUDY_EX_MOOD_CHANGE(CYLProject.StudyCategory studyCate); 
*/
            /// <summary>
            ///   System.Single GetWomenFPAddAtkRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWomenFPAddAtkRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WOMEN_FP_ADD_ATK_RATIO(); 
*/
            /// <summary>
            ///   System.Single GetWomenFPAddRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWomenFPAddRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WOMEN_FP_ADD_RATIO(); 
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
            ///   System.Void OnPersonalityChanged()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnPersonalityChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_PERSONALITY_CHANGED(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_PersonalityManager
        {
            /// <summary>
            /// static  CYLProject.PersonalityManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.PersonalityManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.PersonalityManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."SecretRealmRecordManager"]
    /// [BaseManager<CYLProject.SecretRealmRecordManager>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SecretRealmRecordManager>, Ptr_SecretRealmRecordManager>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "SecretRealmRecordManager", "CYLProject.SecretRealmRecordManager")]
    public partial class SecretRealmRecordManager
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SecretRealmRecordManager(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SecretRealmRecordManager(System.IntPtr ptr) => new Ptr_SecretRealmRecordManager(ptr);
            public static implicit operator System.IntPtr(Ptr_SecretRealmRecordManager ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SecretRealmRecordManager ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."SecretRealmRecordManager"]
        /// </summary>
        partial struct Ptr_SecretRealmRecordManager
        {
            /// <summary>
            /// 0x0 CYLProject.SecretRealmRecordManager _Instance
            /// class ["Assembly-CSharp.dll"."CYLProject"."SecretRealmRecordManager"]
            /// </summary>
            /// <returns>class CYLProject.SecretRealmRecordManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Instance", "CYLProject.SecretRealmRecordManager")]
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
            /// 0x18 System.Collections.Generic.Dictionary<System.String , CYLProject.BattleRoleStatus> RoleStatusCache
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.BattleRoleStatus></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RoleStatusCache", "System.Collections.Generic.Dictionary<System.String,CYLProject.BattleRoleStatus>")]
            public partial nint ROLE_STATUS_CACHE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<System.String , System.Int32> TeamExpChanges
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TeamExpChanges", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint TEAM_EXP_CHANGES { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single CareerExpChange
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CareerExpChange", "System.Single")]
            public partial System.Single CAREER_EXP_CHANGE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] SettlementValues
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SettlementValues", "System.Int32[]")]
            public partial nint SETTLEMENT_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.String , System.Int32> Rewards
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Rewards", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint REWARDS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."SecretRealmRecordManager"]
        /// </summary>
        partial struct Ptr_SecretRealmRecordManager
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
            ///   System.Void AddCareerExp(System.Single addExp)
            /// </summary>
            /// <param name = "addExp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddCareerExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void ADD_CAREER_EXP(System.Single addExp); 
*/
            /// <summary>
            ///   System.Void AddNodeSettlement(System.Int32 idx, System.Int32 cnt)
            /// </summary>
            /// <param name = "idx">struct System.Int32</param>
            /// <param name = "cnt">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNodeSettlement", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_NODE_SETTLEMENT(System.Int32 idx, System.Int32 cnt); 
*/
            /// <summary>
            ///   System.Void AddReward(System.String id, System.Int32 cnt)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "cnt">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddReward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_REWARD(nint id, System.Int32 cnt); 
*/
            /// <summary>
            ///   System.Void AddTeamExp(System.String roleId, System.Int32 addExp)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "addExp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTeamExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_TEAM_EXP(nint roleId, System.Int32 addExp); 
*/
            /// <summary>
            ///   System.Boolean CostHPPercent(System.Single costHPPercent)
            /// </summary>
            /// <param name = "costHPPercent">struct System.Single</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostHPPercent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Boolean COST_HP_PERCENT(System.Single costHPPercent); 
*/
            /// <summary>
            ///   System.Void InitRoleStatus()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitRoleStatus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_ROLE_STATUS(); 
*/
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
            /// <summary>
            ///   System.Void ResetRoleStatus(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetRoleStatus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void RESET_ROLE_STATUS(nint id); 
*/
            /// <summary>
            ///   System.Void Restore(System.String roleId, System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.ValueTuple<System.Int32 , System.Single>> dict)
            /// </summary>
            /// <param name = "roleId">class System.String</param>
            /// <param name = "dict">class System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType , System.ValueTuple<System.Int32 , System.Single>></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Restore", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<CYLProject.BattleAttributeType,System.ValueTuple<System.Int32,System.Single>>", 1)]
            public partial void RESTORE(nint roleId, nint dict); 
*/
            /// <summary>
            ///   System.Void SetRoleStatus(System.String id, CYLProject.BattleRoleStatus battleRoleStatus)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "battleRoleStatus">struct CYLProject.BattleRoleStatus</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRoleStatus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CYLProject.BattleRoleStatus", 1)]
            public partial void SET_ROLE_STATUS(nint id, CYLProject.BattleRoleStatus battleRoleStatus); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BaseManager`1"]
        /// </summary>
        partial struct Ptr_SecretRealmRecordManager
        {
            /// <summary>
            /// static  CYLProject.SecretRealmRecordManager get_Instance()
            /// </summary>
            /// <returns>class CYLProject.SecretRealmRecordManager</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "CYLProject.SecretRealmRecordManager", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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
namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerSave"]
    /// [CYLProject.MarkableObject]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerSave>, Ptr_PlayerSave>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "PlayerSave", "CYLProject.PlayerSave")]
    public partial class PlayerSave
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerSave(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerSave(System.IntPtr ptr) => new Ptr_PlayerSave(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerSave ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PlayerSave ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerSave"]
        /// </summary>
        partial struct Ptr_PlayerSave
        {
            /// <summary>
            /// 0x10 System.Boolean dirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dirty", "System.Boolean")]
            public partial System.Boolean DIRTY { get; set; } 
*/

            /// <summary>
            /// 0x11 System.Boolean <NeedSync>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<NeedSync>k__BackingField", "System.Boolean")]
            public partial System.Boolean NEED_SYNC { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String <JsonString>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<JsonString>k__BackingField", "System.String")]
            public partial nint JSON_STRING { get; set; } 
*/

            /// <summary>
            /// 0x20 System.ComponentModel.PropertyChangedEventHandler PropertyChanged
            /// class ["System.dll"."System.ComponentModel"."PropertyChangedEventHandler"]
            /// </summary>
            /// <returns>class System.ComponentModel.PropertyChangedEventHandler</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PropertyChanged", "System.ComponentModel.PropertyChangedEventHandler")]
            public partial nint PROPERTY_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String FirstName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FirstName", "System.String")]
            public partial nint FIRST_NAME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String LastName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LastName", "System.String")]
            public partial nint LAST_NAME { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String ActiveCareer
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActiveCareer", "System.String")]
            public partial nint ACTIVE_CAREER { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String Designation
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Designation", "System.String")]
            public partial nint DESIGNATION { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 Difficulty
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Difficulty", "System.Int32")]
            public partial System.Int32 DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 Level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 Exp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single[] AttributeValues
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttributeValues", "System.Single[]")]
            public partial nint ATTRIBUTE_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single[] LastAttributeValues
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LastAttributeValues", "System.Single[]")]
            public partial nint LAST_ATTRIBUTE_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x68 System.UInt32[] RecordValues
            /// class ["mscorlib.dll"."System"."UInt32[]"]
            /// </summary>
            /// <returns>class System.UInt32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RecordValues", "System.UInt32[]")]
            public partial nint RECORD_VALUES { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.Dictionary<System.String , CYLProject.SkillInfo> SkillInfoDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.SkillInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillInfoDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.SkillInfo>")]
            public partial nint SKILL_INFO_DICT { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.String> Personality
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Personality", "System.Collections.Generic.List<System.String>")]
            public partial nint PERSONALITY { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.Dictionary<System.String , System.Single> CareerExpDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CareerExpDict", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial nint CAREER_EXP_DICT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.Dictionary<System.String , System.Boolean> CareerUnlockDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CareerUnlockDict", "System.Collections.Generic.Dictionary<System.String,System.Boolean>")]
            public partial nint CAREER_UNLOCK_DICT { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.Dictionary<System.String , System.Int32> TalentPointDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TalentPointDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint TALENT_POINT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.Dictionary<System.String , System.Single> StudyProgressDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StudyProgressDict", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
            public partial nint STUDY_PROGRESS_DICT { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Collections.Generic.Dictionary<System.String , CYLProject.RoleInfo> RoleStateInfoDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , CYLProject.RoleInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RoleStateInfoDict", "System.Collections.Generic.Dictionary<System.String,CYLProject.RoleInfo>")]
            public partial nint ROLE_STATE_INFO_DICT { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Collections.Generic.List<System.String> BattleTeammates
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleTeammates", "System.Collections.Generic.List<System.String>")]
            public partial nint BATTLE_TEAMMATES { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String GoalId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GoalId", "System.String")]
            public partial nint GOAL_ID { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 PartnerChatRest
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PartnerChatRest", "System.Int32")]
            public partial System.Int32 PARTNER_CHAT_REST { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."PlayerSave"]
        /// </summary>
        partial struct Ptr_PlayerSave
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."MarkableObject"]
        /// </summary>
        partial struct Ptr_PlayerSave
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
            ///   System.Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
            /// </summary>
            /// <param name = "value">class System.ComponentModel.PropertyChangedEventHandler</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("add_PropertyChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ComponentModel.PropertyChangedEventHandler", 0)]
            public partial void ADD_PROPERTY_CHANGED(nint value); 
*/
            /// <summary>
            ///   System.Boolean get_Dirty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Dirty", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_DIRTY(); 
*/
            /// <summary>
            ///   System.String get_JsonString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_JsonString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_JSON_STRING(); 
*/
            /// <summary>
            ///   System.Boolean get_NeedSync()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NeedSync", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NEED_SYNC(); 
*/
            /// <summary>
            ///   System.Void OnPropertyChanged(System.String propertyName)
            /// </summary>
            /// <param name = "propertyName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnPropertyChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ON_PROPERTY_CHANGED(nint propertyName); 
*/
            /// <summary>
            ///   System.Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
            /// </summary>
            /// <param name = "value">class System.ComponentModel.PropertyChangedEventHandler</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("remove_PropertyChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ComponentModel.PropertyChangedEventHandler", 0)]
            public partial void REMOVE_PROPERTY_CHANGED(nint value); 
*/
            /// <summary>
            ///   System.Void set_Dirty(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Dirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_DIRTY(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_JsonString(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_JsonString", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_JSON_STRING(nint value); 
*/
            /// <summary>
            ///   System.Void set_NeedSync(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NeedSync", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NEED_SYNC(System.Boolean value); 
*/
            /// <summary>
            ///   System.Boolean SetProperty(T& field, T value, System.String propertyName)
            /// </summary>
            /// <param name = "field">class T&</param>
            /// <param name = "value">class T</param>
            /// <param name = "propertyName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetProperty", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial System.Boolean SET_PROPERTY(nint field, nint value, nint propertyName); 
*/
        }
    }
}
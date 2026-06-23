using Maple.MonoGameAssistant.Core;

namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."CYLProject"."RoleInfo"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RoleInfo>, Ptr_RoleInfo>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "CYLProject", "RoleInfo", "CYLProject.RoleInfo")]
    public partial class RoleInfo
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RoleInfo(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RoleInfo(System.IntPtr ptr) => new Ptr_RoleInfo(ptr);
            public static implicit operator System.IntPtr(Ptr_RoleInfo ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_RoleInfo ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."RoleInfo"]
        /// </summary>
        partial struct Ptr_RoleInfo
        {
            /// <summary>
            /// 0x10 System.Int32 Level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("等级","人物等级")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; }


            /// <summary>
            /// 0x14 System.Int32 Exp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("经验", "人物经验")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; }


            /// <summary>
            /// 0x18 System.Int32 Favorability
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("好感度", "人物好感度")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Favorability", "System.Int32")]
            public partial System.Int32 FAVORABILITY { get; set; }


            /// <summary>
            /// 0x1C System.Boolean InTeam
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("入队", "人物入队状态")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InTeam", "System.Boolean")]
            public partial System.Boolean IN_TEAM { get; set; }


            /// <summary>
            /// 0x20 System.Int32 TotalTalentPoint
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("天赋", "人物天赋点数")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TotalTalentPoint", "System.Int32")]
            public partial System.Int32 TOTAL_TALENT_POINT { get; set; }


            /// <summary>
            /// 0x24 System.Int32 ChatRest
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("交谈", "人物交谈点数")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChatRest", "System.Int32")]
            public partial System.Int32 CHAT_REST { get; set; }


            /// <summary>
            /// 0x28 System.Int32 SendGiftFreeRest
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("赠送", "人物赠送点数")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SendGiftFreeRest", "System.Int32")]
            public partial System.Int32 SEND_GIFT_FREE_REST { get; set; }


            /// <summary>
            /// 0x2C System.Int32 ChallengeRest
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("挑战", "人物挑战点数")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChallengeRest", "System.Int32")]
            public partial System.Int32 CHALLENGE_REST { get; set; }


            /// <summary>
            /// 0x30 System.Int32 ChallengeStage
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyCollection("挑战阶段", "人物挑战阶段")]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChallengeStage", "System.Int32")]
            public partial System.Int32 CHALLENGE_STAGE { get; set; } 


            /// <summary>
            /// 0x38 System.String[] BattleSkills
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleSkills", "System.String[]")]
            public partial PMonoArray<PMonoString> BATTLE_SKILLS { get; set; } 


            /// <summary>
            /// 0x40 System.String[] SlotEquipIds
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SlotEquipIds", "System.String[]")]
            public partial PMonoArray<PMonoString> SLOT_EQUIP_IDS { get; set; } 


            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<System.String , System.Int32> TalentPointDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TalentPointDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint TALENT_POINT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.Dictionary<System.String , System.Int32> ChatDict
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChatDict", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint CHAT_DICT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single[] ExtraAttributes
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ExtraAttributes", "System.Single[]")]
            public partial PMonoArray<float> EXTRA_ATTRIBUTES { get; set; } 


            /// <summary>
            /// 0x60 System.Single[] ExtraBattleAttributes
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ExtraBattleAttributes", "System.Single[]")]
            public partial PMonoArray<float> EXTRA_BATTLE_ATTRIBUTES { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."CYLProject"."RoleInfo"]
        /// </summary>
        partial struct Ptr_RoleInfo
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
    }
}
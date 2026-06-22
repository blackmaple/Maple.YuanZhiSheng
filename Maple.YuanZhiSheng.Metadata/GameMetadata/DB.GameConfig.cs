namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DB"."GameConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameConfig>, Ptr_GameConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DB", "GameConfig", "DB.GameConfig")]
    public partial class GameConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameConfig(System.IntPtr ptr) => new Ptr_GameConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_GameConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GameConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."GameConfig"]
        /// </summary>
        partial struct Ptr_GameConfig
        {
            /// <summary>
            /// 0x0 System.Int32[] <IncludeLanguage>k__BackingField
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IncludeLanguage>k__BackingField", "System.Int32[]")]
            public static partial nint INCLUDE_LANGUAGE { get; set; } 
*/

            /// <summary>
            /// 0x8 System.String <StartBgm>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StartBgm>k__BackingField", "System.String")]
            public static partial nint START_BGM { get; set; } 
*/

            /// <summary>
            /// 0x10 System.String <RoomBgm>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoomBgm>k__BackingField", "System.String")]
            public static partial nint ROOM_BGM { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String <MainPlayerId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MainPlayerId>k__BackingField", "System.String")]
            public static partial nint MAIN_PLAYER_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 <MainPlayerFavMinStage>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MainPlayerFavMinStage>k__BackingField", "System.Int32")]
            public static partial System.Int32 MAIN_PLAYER_FAV_MIN_STAGE { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single <MainPlayerSpecialtyMin>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MainPlayerSpecialtyMin>k__BackingField", "System.Single")]
            public static partial System.Single MAIN_PLAYER_SPECIALTY_MIN { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 <MainPlayerPreLvTalentPoint>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MainPlayerPreLvTalentPoint>k__BackingField", "System.Int32")]
            public static partial System.Int32 MAIN_PLAYER_PRE_LV_TALENT_POINT { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 <PartnerPreLvTalentPoint>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PartnerPreLvTalentPoint>k__BackingField", "System.Int32")]
            public static partial System.Int32 PARTNER_PRE_LV_TALENT_POINT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String <RoomMapTwoId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoomMapTwoId>k__BackingField", "System.String")]
            public static partial nint ROOM_MAP_TWO_ID { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Single <RandomAttributeCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RandomAttributeCap>k__BackingField", "System.Single")]
            public static partial System.Single RANDOM_ATTRIBUTE_CAP { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Single <RandomAttributeRedNum>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RandomAttributeRedNum>k__BackingField", "System.Single")]
            public static partial System.Single RANDOM_ATTRIBUTE_RED_NUM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single <RandomAttributeTotal>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RandomAttributeTotal>k__BackingField", "System.Single")]
            public static partial System.Single RANDOM_ATTRIBUTE_TOTAL { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Single <AttributeCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeCap>k__BackingField", "System.Single")]
            public static partial System.Single ATTRIBUTE_CAP { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 <ScheduleAskEnergy>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ScheduleAskEnergy>k__BackingField", "System.Int32")]
            public static partial System.Int32 SCHEDULE_ASK_ENERGY { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 <ScheduleVisitAddMood>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ScheduleVisitAddMood>k__BackingField", "System.Int32")]
            public static partial System.Int32 SCHEDULE_VISIT_ADD_MOOD { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 <ScheduleVisitAddFav>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ScheduleVisitAddFav>k__BackingField", "System.Int32")]
            public static partial System.Int32 SCHEDULE_VISIT_ADD_FAV { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 <InitMood>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<InitMood>k__BackingField", "System.Int32")]
            public static partial System.Int32 INIT_MOOD { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 <MoodCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MoodCap>k__BackingField", "System.Int32")]
            public static partial System.Int32 MOOD_CAP { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Single <StudyFailMoodRatio>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyFailMoodRatio>k__BackingField", "System.Single")]
            public static partial System.Single STUDY_FAIL_MOOD_RATIO { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single <StudyFailPercent>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyFailPercent>k__BackingField", "System.Single")]
            public static partial System.Single STUDY_FAIL_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Single <StudyBigSuccessMoodRatio>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyBigSuccessMoodRatio>k__BackingField", "System.Single")]
            public static partial System.Single STUDY_BIG_SUCCESS_MOOD_RATIO { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Single <StudyBgiSucessPercent>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyBgiSucessPercent>k__BackingField", "System.Single")]
            public static partial System.Single STUDY_BGI_SUCESS_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Single <StudyDoubleBigSuccessMoodRatio>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StudyDoubleBigSuccessMoodRatio>k__BackingField", "System.Single")]
            public static partial System.Single STUDY_DOUBLE_BIG_SUCCESS_MOOD_RATIO { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 <LittleGameEnergyCost>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LittleGameEnergyCost>k__BackingField", "System.Int32")]
            public static partial System.Int32 LITTLE_GAME_ENERGY_COST { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 <LittleGameDuration>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LittleGameDuration>k__BackingField", "System.Int32")]
            public static partial System.Int32 LITTLE_GAME_DURATION { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 <PreEnergyCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PreEnergyCap>k__BackingField", "System.Int32")]
            public static partial System.Int32 PRE_ENERGY_CAP { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 <PreEnergyCapDay>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PreEnergyCapDay>k__BackingField", "System.Int32")]
            public static partial System.Int32 PRE_ENERGY_CAP_DAY { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 <EnergyCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnergyCap>k__BackingField", "System.Int32")]
            public static partial System.Int32 ENERGY_CAP { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 <RoomRestEnergy>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<RoomRestEnergy>k__BackingField", "System.Int32")]
            public static partial System.Int32 ROOM_REST_ENERGY { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Single <EnergyToExp>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnergyToExp>k__BackingField", "System.Single")]
            public static partial System.Single ENERGY_TO_EXP { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Single <EnergyToCareerExp>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnergyToCareerExp>k__BackingField", "System.Single")]
            public static partial System.Single ENERGY_TO_CAREER_EXP { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 <CalendarRoomRestCnt>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CalendarRoomRestCnt>k__BackingField", "System.Int32")]
            public static partial System.Int32 CALENDAR_ROOM_REST_CNT { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String <WeaponWorkShop>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<WeaponWorkShop>k__BackingField", "System.String")]
            public static partial nint WEAPON_WORK_SHOP { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String <DressWorkShop>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DressWorkShop>k__BackingField", "System.String")]
            public static partial nint DRESS_WORK_SHOP { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String <ConsumablesWorkShop>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ConsumablesWorkShop>k__BackingField", "System.String")]
            public static partial nint CONSUMABLES_WORK_SHOP { get; set; } 
*/

            /// <summary>
            /// 0xB0 DB.DBVec3Pos <StoryStandCenter>k__BackingField
            /// class ["Assembly-CSharp.dll"."DB"."DBVec3Pos"]
            /// </summary>
            /// <returns>class DB.DBVec3Pos</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StoryStandCenter>k__BackingField", "DB.DBVec3Pos")]
            public static partial nint STORY_STAND_CENTER { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Single <StoryStandSpacingX>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StoryStandSpacingX>k__BackingField", "System.Single")]
            public static partial System.Single STORY_STAND_SPACING_X { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Single <StoryStandSpacingY>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<StoryStandSpacingY>k__BackingField", "System.Single")]
            public static partial System.Single STORY_STAND_SPACING_Y { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32 <EnergyCost_PartnerSendGift>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnergyCost_PartnerSendGift>k__BackingField", "System.Int32")]
            public static partial System.Int32 ENERGY_COST_PARTNER_SEND_GIFT { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 <EnergyCost_PartnerChallenge>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<EnergyCost_PartnerChallenge>k__BackingField", "System.Int32")]
            public static partial System.Int32 ENERGY_COST_PARTNER_CHALLENGE { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Int32 <PartnerChatCount>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PartnerChatCount>k__BackingField", "System.Int32")]
            public static partial System.Int32 PARTNER_CHAT_COUNT { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Int32 <PartnerSendGiftFreeCount>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PartnerSendGiftFreeCount>k__BackingField", "System.Int32")]
            public static partial System.Int32 PARTNER_SEND_GIFT_FREE_COUNT { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Int32 <PartnerChallengeCount>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PartnerChallengeCount>k__BackingField", "System.Int32")]
            public static partial System.Int32 PARTNER_CHALLENGE_COUNT { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.String <DefaultMapSignId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DefaultMapSignId>k__BackingField", "System.String")]
            public static partial nint DEFAULT_MAP_SIGN_ID { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Single <BattleStartPP>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleStartPP>k__BackingField", "System.Single")]
            public static partial System.Single BATTLE_START_PP { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Single <BattleAtkPP>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleAtkPP>k__BackingField", "System.Single")]
            public static partial System.Single BATTLE_ATK_PP { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Single <BattleDefPP>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleDefPP>k__BackingField", "System.Single")]
            public static partial System.Single BATTLE_DEF_PP { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Single <BattleSkillPP>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleSkillPP>k__BackingField", "System.Single")]
            public static partial System.Single BATTLE_SKILL_PP { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Single <PPBarCap>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PPBarCap>k__BackingField", "System.Single")]
            public static partial System.Single PP_BAR_CAP { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Single <ActionBarLength>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ActionBarLength>k__BackingField", "System.Single")]
            public static partial System.Single ACTION_BAR_LENGTH { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Int32 <MissionFollowLimit>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MissionFollowLimit>k__BackingField", "System.Int32")]
            public static partial System.Int32 MISSION_FOLLOW_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x100 System.String <DefaultTerrainId>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DefaultTerrainId>k__BackingField", "System.String")]
            public static partial nint DEFAULT_TERRAIN_ID { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 <TavernFoodBuyLimit>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TavernFoodBuyLimit>k__BackingField", "System.Int32")]
            public static partial System.Int32 TAVERN_FOOD_BUY_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 <TavernWineBuyLimit>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TavernWineBuyLimit>k__BackingField", "System.Int32")]
            public static partial System.Int32 TAVERN_WINE_BUY_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Single <BattleSuccessAddAttribute>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BattleSuccessAddAttribute>k__BackingField", "System.Single")]
            public static partial System.Single BATTLE_SUCCESS_ADD_ATTRIBUTE { get; set; } 
*/

            /// <summary>
            /// 0x118 DB.GameConfig config
            /// class ["Assembly-CSharp.dll"."DB"."GameConfig"]
            /// </summary>
            /// <returns>class DB.GameConfig</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("config", "DB.GameConfig")]
            public static partial nint CONFIG { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DB"."GameConfig"]
        /// </summary>
        partial struct Ptr_GameConfig
        {
            /// <summary>
            /// static  System.Void _Load(System.String json)
            /// </summary>
            /// <param name = "json">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("_Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void _LOAD(nint json); 
*/
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Single get_ActionBarLength()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ActionBarLength", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_ACTION_BAR_LENGTH(); 
*/
            /// <summary>
            /// static  System.Single get_AttributeCap()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_ATTRIBUTE_CAP(); 
*/
            /// <summary>
            /// static  System.Single get_BattleAtkPP()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleAtkPP", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_BATTLE_ATK_PP(); 
*/
            /// <summary>
            /// static  System.Single get_BattleDefPP()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleDefPP", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_BATTLE_DEF_PP(); 
*/
            /// <summary>
            /// static  System.Single get_BattleSkillPP()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleSkillPP", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_BATTLE_SKILL_PP(); 
*/
            /// <summary>
            /// static  System.Single get_BattleStartPP()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleStartPP", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_BATTLE_START_PP(); 
*/
            /// <summary>
            /// static  System.Single get_BattleSuccessAddAttribute()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BattleSuccessAddAttribute", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_BATTLE_SUCCESS_ADD_ATTRIBUTE(); 
*/
            /// <summary>
            /// static  System.Int32 get_CalendarRoomRestCnt()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CalendarRoomRestCnt", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_CALENDAR_ROOM_REST_CNT(); 
*/
            /// <summary>
            /// static  System.String get_ConsumablesWorkShop()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ConsumablesWorkShop", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_CONSUMABLES_WORK_SHOP(); 
*/
            /// <summary>
            /// static  System.String get_DefaultMapSignId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DefaultMapSignId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_DEFAULT_MAP_SIGN_ID(); 
*/
            /// <summary>
            /// static  System.String get_DefaultTerrainId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DefaultTerrainId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_DEFAULT_TERRAIN_ID(); 
*/
            /// <summary>
            /// static  System.String get_DressWorkShop()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DressWorkShop", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_DRESS_WORK_SHOP(); 
*/
            /// <summary>
            /// static  System.Int32 get_EnergyCap()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnergyCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_ENERGY_CAP(); 
*/
            /// <summary>
            /// static  System.Int32 get_EnergyCost_PartnerChallenge()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnergyCost_PartnerChallenge", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_ENERGY_COST_PARTNER_CHALLENGE(); 
*/
            /// <summary>
            /// static  System.Int32 get_EnergyCost_PartnerSendGift()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnergyCost_PartnerSendGift", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_ENERGY_COST_PARTNER_SEND_GIFT(); 
*/
            /// <summary>
            /// static  System.Single get_EnergyToCareerExp()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnergyToCareerExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_ENERGY_TO_CAREER_EXP(); 
*/
            /// <summary>
            /// static  System.Single get_EnergyToExp()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EnergyToExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_ENERGY_TO_EXP(); 
*/
            /// <summary>
            /// static  System.Int32[] get_IncludeLanguage()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IncludeLanguage", "System.Int32[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INCLUDE_LANGUAGE(); 
*/
            /// <summary>
            /// static  System.Int32 get_InitMood()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InitMood", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_INIT_MOOD(); 
*/
            /// <summary>
            /// static  System.Int32 get_LittleGameDuration()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LittleGameDuration", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_LITTLE_GAME_DURATION(); 
*/
            /// <summary>
            /// static  System.Int32 get_LittleGameEnergyCost()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LittleGameEnergyCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_LITTLE_GAME_ENERGY_COST(); 
*/
            /// <summary>
            /// static  System.Int32 get_MainPlayerFavMinStage()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainPlayerFavMinStage", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_MAIN_PLAYER_FAV_MIN_STAGE(); 
*/
            /// <summary>
            /// static  System.String get_MainPlayerId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainPlayerId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_MAIN_PLAYER_ID(); 
*/
            /// <summary>
            /// static  System.Int32 get_MainPlayerPreLvTalentPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainPlayerPreLvTalentPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_MAIN_PLAYER_PRE_LV_TALENT_POINT(); 
*/
            /// <summary>
            /// static  System.Single get_MainPlayerSpecialtyMin()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainPlayerSpecialtyMin", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_MAIN_PLAYER_SPECIALTY_MIN(); 
*/
            /// <summary>
            /// static  System.Int32 get_MissionFollowLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MissionFollowLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_MISSION_FOLLOW_LIMIT(); 
*/
            /// <summary>
            /// static  System.Int32 get_MoodCap()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MoodCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_MOOD_CAP(); 
*/
            /// <summary>
            /// static  System.Int32 get_PartnerChallengeCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PartnerChallengeCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PARTNER_CHALLENGE_COUNT(); 
*/
            /// <summary>
            /// static  System.Int32 get_PartnerChatCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PartnerChatCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PARTNER_CHAT_COUNT(); 
*/
            /// <summary>
            /// static  System.Int32 get_PartnerPreLvTalentPoint()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PartnerPreLvTalentPoint", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PARTNER_PRE_LV_TALENT_POINT(); 
*/
            /// <summary>
            /// static  System.Int32 get_PartnerSendGiftFreeCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PartnerSendGiftFreeCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PARTNER_SEND_GIFT_FREE_COUNT(); 
*/
            /// <summary>
            /// static  System.Single get_PPBarCap()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PPBarCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_PP_BAR_CAP(); 
*/
            /// <summary>
            /// static  System.Int32 get_PreEnergyCap()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PreEnergyCap", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PRE_ENERGY_CAP(); 
*/
            /// <summary>
            /// static  System.Int32 get_PreEnergyCapDay()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PreEnergyCapDay", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_PRE_ENERGY_CAP_DAY(); 
*/
            /// <summary>
            /// static  System.Single get_RandomAttributeCap()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RandomAttributeCap", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_RANDOM_ATTRIBUTE_CAP(); 
*/
            /// <summary>
            /// static  System.Single get_RandomAttributeRedNum()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RandomAttributeRedNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_RANDOM_ATTRIBUTE_RED_NUM(); 
*/
            /// <summary>
            /// static  System.Single get_RandomAttributeTotal()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RandomAttributeTotal", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_RANDOM_ATTRIBUTE_TOTAL(); 
*/
            /// <summary>
            /// static  System.String get_RoomBgm()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoomBgm", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ROOM_BGM(); 
*/
            /// <summary>
            /// static  System.String get_RoomMapTwoId()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoomMapTwoId", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_ROOM_MAP_TWO_ID(); 
*/
            /// <summary>
            /// static  System.Int32 get_RoomRestEnergy()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RoomRestEnergy", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_ROOM_REST_ENERGY(); 
*/
            /// <summary>
            /// static  System.Int32 get_ScheduleAskEnergy()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ScheduleAskEnergy", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_SCHEDULE_ASK_ENERGY(); 
*/
            /// <summary>
            /// static  System.Int32 get_ScheduleVisitAddFav()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ScheduleVisitAddFav", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_SCHEDULE_VISIT_ADD_FAV(); 
*/
            /// <summary>
            /// static  System.Int32 get_ScheduleVisitAddMood()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ScheduleVisitAddMood", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_SCHEDULE_VISIT_ADD_MOOD(); 
*/
            /// <summary>
            /// static  System.String get_StartBgm()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StartBgm", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_START_BGM(); 
*/
            /// <summary>
            /// static  DB.DBVec3Pos get_StoryStandCenter()
            /// </summary>
            /// <returns>class DB.DBVec3Pos</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoryStandCenter", "DB.DBVec3Pos", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_STORY_STAND_CENTER(); 
*/
            /// <summary>
            /// static  System.Single get_StoryStandSpacingX()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoryStandSpacingX", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STORY_STAND_SPACING_X(); 
*/
            /// <summary>
            /// static  System.Single get_StoryStandSpacingY()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoryStandSpacingY", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STORY_STAND_SPACING_Y(); 
*/
            /// <summary>
            /// static  System.Single get_StudyBgiSucessPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyBgiSucessPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STUDY_BGI_SUCESS_PERCENT(); 
*/
            /// <summary>
            /// static  System.Single get_StudyBigSuccessMoodRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyBigSuccessMoodRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STUDY_BIG_SUCCESS_MOOD_RATIO(); 
*/
            /// <summary>
            /// static  System.Single get_StudyDoubleBigSuccessMoodRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyDoubleBigSuccessMoodRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STUDY_DOUBLE_BIG_SUCCESS_MOOD_RATIO(); 
*/
            /// <summary>
            /// static  System.Single get_StudyFailMoodRatio()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyFailMoodRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STUDY_FAIL_MOOD_RATIO(); 
*/
            /// <summary>
            /// static  System.Single get_StudyFailPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StudyFailPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Single GET_STUDY_FAIL_PERCENT(); 
*/
            /// <summary>
            /// static  System.Int32 get_TavernFoodBuyLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TavernFoodBuyLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_TAVERN_FOOD_BUY_LIMIT(); 
*/
            /// <summary>
            /// static  System.Int32 get_TavernWineBuyLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TavernWineBuyLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_TAVERN_WINE_BUY_LIMIT(); 
*/
            /// <summary>
            /// static  System.String get_WeaponWorkShop()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_WeaponWorkShop", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_WEAPON_WORK_SHOP(); 
*/
            /// <summary>
            /// static  Cysharp.Threading.Tasks.UniTask LoadAsync()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTask</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAsync", "Cysharp.Threading.Tasks.UniTask", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial Cysharp.Threading.Tasks.UniTask LOAD_ASYNC(); 
*/
            /// <summary>
            /// static  System.Void set_ActionBarLength(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ActionBarLength", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_ACTION_BAR_LENGTH(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_AttributeCap(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_ATTRIBUTE_CAP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_BattleAtkPP(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleAtkPP", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_BATTLE_ATK_PP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_BattleDefPP(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleDefPP", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_BATTLE_DEF_PP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_BattleSkillPP(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleSkillPP", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_BATTLE_SKILL_PP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_BattleStartPP(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleStartPP", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_BATTLE_START_PP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_BattleSuccessAddAttribute(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BattleSuccessAddAttribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_BATTLE_SUCCESS_ADD_ATTRIBUTE(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_CalendarRoomRestCnt(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CalendarRoomRestCnt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_CALENDAR_ROOM_REST_CNT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_ConsumablesWorkShop(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ConsumablesWorkShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_CONSUMABLES_WORK_SHOP(nint value); 
*/
            /// <summary>
            /// static  System.Void set_DefaultMapSignId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DefaultMapSignId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_DEFAULT_MAP_SIGN_ID(nint value); 
*/
            /// <summary>
            /// static  System.Void set_DefaultTerrainId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DefaultTerrainId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_DEFAULT_TERRAIN_ID(nint value); 
*/
            /// <summary>
            /// static  System.Void set_DressWorkShop(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DressWorkShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_DRESS_WORK_SHOP(nint value); 
*/
            /// <summary>
            /// static  System.Void set_EnergyCap(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnergyCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_ENERGY_CAP(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_EnergyCost_PartnerChallenge(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnergyCost_PartnerChallenge", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_ENERGY_COST_PARTNER_CHALLENGE(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_EnergyCost_PartnerSendGift(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnergyCost_PartnerSendGift", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_ENERGY_COST_PARTNER_SEND_GIFT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_EnergyToCareerExp(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnergyToCareerExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_ENERGY_TO_CAREER_EXP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_EnergyToExp(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_EnergyToExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_ENERGY_TO_EXP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_IncludeLanguage(System.Int32[] value)
            /// </summary>
            /// <param name = "value">class System.Int32[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IncludeLanguage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            public static partial void SET_INCLUDE_LANGUAGE(nint value); 
*/
            /// <summary>
            /// static  System.Void set_InitMood(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_InitMood", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_INIT_MOOD(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_LittleGameDuration(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LittleGameDuration", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_LITTLE_GAME_DURATION(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_LittleGameEnergyCost(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LittleGameEnergyCost", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_LITTLE_GAME_ENERGY_COST(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_MainPlayerFavMinStage(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MainPlayerFavMinStage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_MAIN_PLAYER_FAV_MIN_STAGE(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_MainPlayerId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MainPlayerId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_MAIN_PLAYER_ID(nint value); 
*/
            /// <summary>
            /// static  System.Void set_MainPlayerPreLvTalentPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MainPlayerPreLvTalentPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_MAIN_PLAYER_PRE_LV_TALENT_POINT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_MainPlayerSpecialtyMin(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MainPlayerSpecialtyMin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_MAIN_PLAYER_SPECIALTY_MIN(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_MissionFollowLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MissionFollowLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_MISSION_FOLLOW_LIMIT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_MoodCap(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MoodCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_MOOD_CAP(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PartnerChallengeCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PartnerChallengeCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PARTNER_CHALLENGE_COUNT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PartnerChatCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PartnerChatCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PARTNER_CHAT_COUNT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PartnerPreLvTalentPoint(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PartnerPreLvTalentPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PARTNER_PRE_LV_TALENT_POINT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PartnerSendGiftFreeCount(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PartnerSendGiftFreeCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PARTNER_SEND_GIFT_FREE_COUNT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PPBarCap(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PPBarCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_PP_BAR_CAP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_PreEnergyCap(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PreEnergyCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PRE_ENERGY_CAP(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_PreEnergyCapDay(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PreEnergyCapDay", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_PRE_ENERGY_CAP_DAY(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_RandomAttributeCap(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RandomAttributeCap", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_RANDOM_ATTRIBUTE_CAP(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_RandomAttributeRedNum(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RandomAttributeRedNum", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_RANDOM_ATTRIBUTE_RED_NUM(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_RandomAttributeTotal(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RandomAttributeTotal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_RANDOM_ATTRIBUTE_TOTAL(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_RoomBgm(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoomBgm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_ROOM_BGM(nint value); 
*/
            /// <summary>
            /// static  System.Void set_RoomMapTwoId(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoomMapTwoId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_ROOM_MAP_TWO_ID(nint value); 
*/
            /// <summary>
            /// static  System.Void set_RoomRestEnergy(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_RoomRestEnergy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_ROOM_REST_ENERGY(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_ScheduleAskEnergy(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ScheduleAskEnergy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_SCHEDULE_ASK_ENERGY(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_ScheduleVisitAddFav(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ScheduleVisitAddFav", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_SCHEDULE_VISIT_ADD_FAV(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_ScheduleVisitAddMood(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ScheduleVisitAddMood", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_SCHEDULE_VISIT_ADD_MOOD(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_StartBgm(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StartBgm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_START_BGM(nint value); 
*/
            /// <summary>
            /// static  System.Void set_StoryStandCenter(DB.DBVec3Pos value)
            /// </summary>
            /// <param name = "value">class DB.DBVec3Pos</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StoryStandCenter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DB.DBVec3Pos", 0)]
            public static partial void SET_STORY_STAND_CENTER(nint value); 
*/
            /// <summary>
            /// static  System.Void set_StoryStandSpacingX(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StoryStandSpacingX", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STORY_STAND_SPACING_X(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StoryStandSpacingY(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StoryStandSpacingY", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STORY_STAND_SPACING_Y(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StudyBgiSucessPercent(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyBgiSucessPercent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STUDY_BGI_SUCESS_PERCENT(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StudyBigSuccessMoodRatio(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyBigSuccessMoodRatio", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STUDY_BIG_SUCCESS_MOOD_RATIO(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StudyDoubleBigSuccessMoodRatio(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyDoubleBigSuccessMoodRatio", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STUDY_DOUBLE_BIG_SUCCESS_MOOD_RATIO(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StudyFailMoodRatio(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyFailMoodRatio", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STUDY_FAIL_MOOD_RATIO(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_StudyFailPercent(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_StudyFailPercent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial void SET_STUDY_FAIL_PERCENT(System.Single value); 
*/
            /// <summary>
            /// static  System.Void set_TavernFoodBuyLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TavernFoodBuyLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_TAVERN_FOOD_BUY_LIMIT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_TavernWineBuyLimit(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_TavernWineBuyLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial void SET_TAVERN_WINE_BUY_LIMIT(System.Int32 value); 
*/
            /// <summary>
            /// static  System.Void set_WeaponWorkShop(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_WeaponWorkShop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial void SET_WEAPON_WORK_SHOP(nint value); 
*/
            /// <summary>
            /// static  System.Void Unload()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Unload", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void UNLOAD(); 
*/
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
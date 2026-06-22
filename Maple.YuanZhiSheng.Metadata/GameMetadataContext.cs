using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maple.YuanZhiSheng.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]
    //游戏周期
    [ContextMemberMetadata<GameProcessManager>]
    //游戏模块管理器
    [ContextMemberMetadata<ModelManager>]
    [ContextMemberMetadata<StateModel>]
    [ContextMemberMetadata<PlayerModel>]
    [ContextMemberMetadata<BagModel>]

    //管理器
    [ContextMemberMetadata<MC>]
    //窗口
    [ContextMemberMetadata<WinManager>]
    //本地化
    [ContextMemberMetadata<LocalizationManager>]

    //人物26个属性值
    [ContextMemberMetadata<AttributeData>]
    //人物战斗19属性值
    [ContextMemberMetadata<BattleAttributeData>]
    //人物职业
    [ContextMemberMetadata<CareerData>]
    //人物称号
    [ContextMemberMetadata<PlayerDesignationData>]
    
    //人物个性
    [ContextMemberMetadata<PersonalityData>]
    //人物课业
    [ContextMemberMetadata<StudyData>]

    //道具
    [ContextMemberMetadata<ItemData>]
    //技能
    [ContextMemberMetadata<BattleSkillData>]
    //技能大类
    [ContextMemberMetadata<BattleSkillCategoryData>]

    //人物信息
    [ContextMemberMetadata<RoleInfo>]
    [ContextMemberMetadata<RoleData>]
    [ContextMemberMetadata<PartnerData>]
    [ContextMemberMetadata<GameConfig>]

    public partial class GameMetadataContext
    {
    }
}

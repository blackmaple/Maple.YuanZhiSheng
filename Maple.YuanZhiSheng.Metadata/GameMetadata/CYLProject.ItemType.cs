namespace Maple.YuanZhiSheng.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll"."CYLProject"."ItemType"]
    /// </summary>
    public enum ItemType : System.UInt32
    {
        All = 0xFFFFFFFF,
        Resource = 0x00000000,
        Consume = 0x00000001,
        Weapon = 0x00000002,
        Armor = 0x00000003,
        Accessory = 0x00000004,
        SkillBook = 0x00000005,
        Material = 0x00000006,
        Other = 0x00000007
    }
}
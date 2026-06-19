namespace Maple.YuanZhiSheng.Metadata
{
    public readonly partial struct GameEnvService(GameResourceCache cache)
    {
        GameResourceCache Cache { get; } = cache;   
        
    }
}

using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
using Maple.UnityAssistant.Context.UnityHook;
using Maple.UnityAssistant.Context.UnityMetadata;
using Maple.UnityAssistant.Resource;
using Maple.XScheduler;
using Maple.YuanZhiSheng.Metadata;
using Microsoft.Extensions.Logging;
namespace Maple.YuanZhiSheng.UI;

public sealed class GameContextService(
    ILogger<GameContextService> logger,
    MonoRuntimeContext runtimeContext,
    MonoTaskScheduler taskScheduler,
    WinMsgHookFactory winMsgHookFactory,
    MonoInternalCallService internalCallService,
     MonoGameSettings gameSettings,
    IHookFactory hookFactory,
    IXSchedulerFactory schedulerFactory)
    : GameContextService<GameMetadataContext>(logger, runtimeContext, taskScheduler, winMsgHookFactory, internalCallService, gameSettings, hookFactory, schedulerFactory)
{
    protected override GameMetadataContext LoadContextMetadata()
    {
        var searchService = new Maple.MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
        searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
        {
            Classes = GameMetadataContext.MonoJsonClassDTO,
            Methods = GameMetadataContext.MonoJsonMethodDTO,
            Fields = GameMetadataContext.MonoJsonFieldDTO,
        });
        return new GameMetadataContext(Logger, searchService, RuntimeContext);
    }

    //public override void BlockInput(IImGuiUIView view)
    //{
    //    var unityMetadataSearchService = UnityMetadataSearchService;
    //    if (unityMetadataSearchService != null)
    //    {
    //        UnityBlockInputService.Create(HookFactory, view, unityMetadataSearchService);
    //    }
    //}
    //public override bool TryDrawLauncher(out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
    //{
    //    nativePtr = default;
    //    u0 = 0;
    //    v0 = 0;
    //    u1 = 0;
    //    v1 = 0;
    //    return false;
    //}
    //public override bool TryGetImageInfo(string? category, string objectId, string? image, out nint nativePtr, out float u0, out float v0, out float u1, out float v1)
    //{
    //    nativePtr = default;
    //    u0 = 0;
    //    v0 = 0;
    //    u1 = 0;
    //    v1 = 0;
    //    return false;
    //}
    //public override void PlatformSetImeDataFn(bool on)
    //{
    //     base.PlatformSetImeDataFn(on);
    //}
    public required GameResourceCache Cache { get; set; }
    public required GameSwitchDisplayDTO[] GameSwitches { get; set; }
    protected override async ValueTask LoadGameResourcesAsync()
    {
        this.Cache = await this.MonoTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);
        this.GameSwitches = [.. this.LoadSwitches()];
        await this.ShowMsgAsync("游戏资源加载完成").ConfigureAwait(false);
        return;
    }



    private IEnumerable<GameSwitchDisplayDTO> LoadSwitches()
    {
        yield return new GameSwitchDisplayDTO() { ObjectId = EnumGameSwitchCategory.Test.ToString(), DisplayName = "Test", DisplayDesc = "Test", UIType = (int)EnumGameSwitchUIType.Button };
    }
    public override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
    {
        return ValueTask.FromResult(this.GameSwitches);
    }
    public override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
    {
        var first = GameSwitches.Where(p => p.ObjectId == gameSwitchModify.SwitchObjectId).FirstOrDefault();
        if (!Enum.TryParse<EnumGameSwitchCategory>(first?.ObjectId, out var category))
        {
            return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND:{gameSwitchModify.SwitchObjectId}");
        }
        switch (category)
        {
            case EnumGameSwitchCategory.Test:
                {
                    var gameEnvService = await this.LoadGameEnvServiceAsync().ConfigureAwait(false);
                    await this.MTaskAsync(gameEnvService, (p, env) => env.LogModel()).ConfigureAwait(false);
                }
                break;
        }
        return first;
    }


    public override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
    {
        return new ValueTask<GameCurrencyDisplayDTO[]>(this.Cache.CurrencyResources);
    }
    public override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
    {
        var gameEnv = await this.LoadGameEnvServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MTaskAsync((gameEnv, currencyObjectDTO), (p, args) => args.gameEnv.GetCurrencyInfo(args.currencyObjectDTO)).ConfigureAwait(false);
    }
    public override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
    {
        var gameEnv = await this.LoadGameEnvServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MTaskAsync((gameEnv, currencyModifyDTO), (p, args) => args.gameEnv.UpdateCurrencyInfo(args.currencyModifyDTO)).ConfigureAwait(false);
    }

    public override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
    {
        return new ValueTask<GameInventoryDisplayDTO[]>(this.Cache.InventoryResources);
    }
    public override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
    {
        var gameEnv = await this.LoadGameEnvServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MTaskAsync((gameEnv, inventoryObjectDTO), (p, args) => args.gameEnv.GetInventoryInfo(args.inventoryObjectDTO)).ConfigureAwait(false);
    }
    public override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryModifyDTO)
    {
        var gameEnv = await this.LoadGameEnvServiceThrowIfNotLoadedAsync().ConfigureAwait(false);
        return await this.MTaskAsync((gameEnv, inventoryModifyDTO), (p, args) => args.gameEnv.UpdateInventoryInfo(args.inventoryModifyDTO)).ConfigureAwait(false);

    }

    public override ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
    {
        return new ValueTask<GameCharacterDisplayDTO[]>(this.Cache.CharacterResources);
    }
    public override ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
    {
        return base.GetCharacterStatusAsync(characterObjectDTO);
    }
    public override ValueTask<GameCharacterStatusDTO> UpdateCharacterStatusAsync(GameCharacterModifyDTO characterModifyDTO)
    {
        return base.UpdateCharacterStatusAsync(characterModifyDTO);
    }


    private Task<bool> ShowMsgAsync(string msg)
    {
        return this.XTaskAsync((msg), static (p, msg) => p.Cache.ShowMsg(msg));
    }

    private Task<GameEnvService> LoadGameEnvServiceThrowIfNotLoadedAsync()
    {
        return this.MTaskAsync(this.Cache, (p, cache) => GameEnvService.CreateThrowIfNotLoaded(cache));
    }

    private Task<GameEnvService> LoadGameEnvServiceAsync()
    {
        return this.MTaskAsync(this.Cache, (p, cache) => GameEnvService.Create(cache));
    }


}



public enum EnumGameSwitchCategory
{
    Test = 0,
}

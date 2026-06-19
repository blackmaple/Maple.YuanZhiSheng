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

    protected override async ValueTask LoadGameResourcesAsync()
    {
        this.Cache = await this.MonoTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);
        await this.ShowMsgAsync("游戏资源加载完成").ConfigureAwait(false);
        return;
    }

    public override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
    {
        return new ValueTask<GameInventoryDisplayDTO[]>(this.Cache.InventoryResources);
    }


    private Task<bool> ShowMsgAsync(string msg)
    {
        return this.XTaskAsync((msg), static (p, msg) => p.Cache.ShowMsg(msg));
    }
}
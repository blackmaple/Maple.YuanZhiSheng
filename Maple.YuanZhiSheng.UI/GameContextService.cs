using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.ImGui.Backends.ImGuiCore;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
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

    public required GameResourceCache Cache { get; set; }

    protected override UnityMetadataSearchService? LoadUnityMetadataSearchService()
    {
        return base.LoadUnityMetadataSearchService();
    }

    public override void BlockInput(IImGuiUIView view)
    {
        base.BlockInput(view);
    }

    protected override async ValueTask LoadGameResourcesAsync()
    {
        this.Cache = await this.MonoTaskAsync(p => GameResourceCache.Create(p)).ConfigureAwait(false);
    }
}
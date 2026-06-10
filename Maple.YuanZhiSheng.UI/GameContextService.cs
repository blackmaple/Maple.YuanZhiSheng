using Maple.Hook.Abstractions;
using Maple.Hook.WinMsg;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.DllProxyDobbyHook;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.UnityAssistant.Context;
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

    protected override ValueTask LoadGameResourcesAsync()
    {
        throw new NotImplementedException();
    }
}
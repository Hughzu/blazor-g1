using ImportExport.Blazor.Communication;
using ImportExport.Blazor.States;
using Microsoft.Extensions.DependencyInjection;

namespace ImportExport.Blazor;

public static class ImportExportRegister
{
    public static void Register(IServiceCollection services)
    {
        services.AddScoped<IExportService, ExportService>();
        services.AddScoped<IImportService, ImportService>();
        
        services.AddSingleton<ImportExportState>();
    }
}
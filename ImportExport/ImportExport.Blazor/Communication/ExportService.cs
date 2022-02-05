using System.Collections.Generic;
using ImportExport.Blazor.Domain;

namespace ImportExport.Blazor.Communication;

public class ExportService : IExportService
{
    public List<ExportReport> GetExportReports()
    {
        return new List<ExportReport>();
    }
}
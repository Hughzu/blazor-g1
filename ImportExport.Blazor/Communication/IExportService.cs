using System.Collections.Generic;
using ImportExport.Blazor.Domain;

namespace ImportExport.Blazor.Communication;

public interface IExportService
{
    List<ExportReport> GetExportReports();
}
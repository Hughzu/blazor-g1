using System.Collections.Generic;
using ImportExport.Blazor.Domain;

namespace ImportExport.Blazor.Communication;

public interface IImportService
{
    List<ImportReport> GetImportReports();
}
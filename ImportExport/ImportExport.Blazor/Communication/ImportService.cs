using System.Collections.Generic;
using ImportExport.Blazor.Domain;

namespace ImportExport.Blazor.Communication;

public class ImportService : IImportService
{
    public List<ImportReport> GetImportReports()
    {
        return new List<ImportReport>();
    }
}
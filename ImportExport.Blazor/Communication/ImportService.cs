using ImportExport.Domain;

namespace ImportExport.Communication;

public class ImportService : IImportService
{
    public List<ImportReport> GetImportReports()
    {
        return new List<ImportReport>();
    }
}
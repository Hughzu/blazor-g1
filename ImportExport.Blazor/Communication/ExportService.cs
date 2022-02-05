using ImportExport.Domain;

namespace ImportExport.Communication;

public class ExportService : IExportService
{
    public List<ExportReport> GetExportReports()
    {
        return new List<ExportReport>();
    }
}
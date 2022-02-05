using ImportExport.Domain;

namespace ImportExport.Communication;

public interface IExportService
{
    List<ExportReport> GetExportReports();
}
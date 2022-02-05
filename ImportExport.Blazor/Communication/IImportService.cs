using ImportExport.Domain;

namespace ImportExport.Communication;

public interface IImportService
{
    List<ImportReport> GetImportReports();
}
namespace ImportExport.Blazor.States;

public class ImportExportState
{
    private List<string> _classes = new List<string>();
    public List<string> Classes
    {
        get
        {
            return _classes;
        }
        set
        {
            _classes = value;
            NotifyStateChanged();
        }
    }

    public void AddClass(string className)
    {
        _classes.Add(className);
        NotifyStateChanged();
    }

    public event Action OnStateChange;
    private void NotifyStateChanged() => OnStateChange?.Invoke();
}
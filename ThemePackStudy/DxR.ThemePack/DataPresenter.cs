using Infragistics.Windows.Themes;

namespace DxR.ThemePack;

public class DataPresenter : DataPresenterResourceSet<DataPresenterLocator>
{
    public static DataPresenter Instance { get; }= new();
}
using Infragistics.Windows.Themes;

namespace DxR.ThemePack;

public class Editors : DataPresenterResourceSet<EditorsLocator>
{
    public static Editors Instance { get; } = new();
}
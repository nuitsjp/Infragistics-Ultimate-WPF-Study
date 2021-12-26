using Infragistics.Windows.Themes;

namespace DxR.ThemePack;

public class Primitives : DataPresenterResourceSet<PrimitivesLocator>
{
    public static Primitives Instance { get; } = new();
}
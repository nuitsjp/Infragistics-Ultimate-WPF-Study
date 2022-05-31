using System.ComponentModel;
using System.Reflection;
using Infragistics.Windows.Themes;

namespace DxR.ThemePack;

[EditorBrowsable(EditorBrowsableState.Never)]
public class EditorsLocator : ResourceSetLocator
{
    public override Assembly Assembly => GetType().Assembly;
    public override string Theme => "DxR";
    public override string Grouping => DataPresenterGeneric.Instance.Grouping;
    public override string ResourcePath => @"ResourceSets\Editors\EditorsRoyalLight.xaml";
}
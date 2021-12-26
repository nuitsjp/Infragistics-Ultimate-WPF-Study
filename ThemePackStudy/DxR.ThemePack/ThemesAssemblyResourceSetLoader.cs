using Infragistics.Windows;
using Infragistics.Windows.Themes;

namespace DxR.ThemePack;

class ThemesAssemblyResourceSetLoader : AssemblyResourceSetLoader
{
    protected override void OnRegisterResourceSets(string? groupingName)
    {
		if (groupingName == null)
        {
            RegisterResourceSet(Primitives.Instance);
            RegisterResourceSet(Editors.Instance);
            RegisterResourceSet(DataPresenter.Instance);
        }
        else
        {
            switch (groupingName)
            {
                case "Primitives":
                    RegisterResourceSet(Primitives.Instance);
                    break;
                case "DataPresenter":
                    RegisterResourceSet(DataPresenter.Instance);
                    break;
                case "Editors":
                    RegisterResourceSet(Editors.Instance);
                    break;
            }
        }
	}
}
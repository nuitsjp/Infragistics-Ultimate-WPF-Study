using Infragistics.Windows.Themes;

// ReSharper disable once CheckNamespace
namespace MyThemePack.ResourceSets.OrangePeel
{
    public class ThemesOrangePeelAssemblyResourceSetLoader : AssemblyResourceSetLoader
    {
        protected override void OnRegisterResourceSets(string groupingName)
        {
            if (groupingName == null)
            {
                //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Primitives.Instance);
                //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Editors.Instance);
                ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.DataPresenter.Instance);
            }
            else
            {
                switch (groupingName)
                {
                    case "Primitives":
                        //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Primitives.Instance);
                        break;
                    case "DataPresenter":
                        ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.DataPresenter.Instance);
                        break;
                    case "Editors":
                        //ThemesOrangePeelAssemblyResourceSetLoader.RegisterResourceSet(OrangePeel.Editors.Instance);
                        break;
                }
            }
        }
    }
}
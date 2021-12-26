using System.Windows;
using Infragistics.Windows.Themes;
using System.Windows.Markup;
using DxR.ThemePack;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]

[assembly: AssemblyResourceSetLoader(typeof(ThemesAssemblyResourceSetLoader))]
[assembly: XmlnsPrefix("http://jp.ricoh.com/Themes/DxR", "dxr")]
[assembly: XmlnsDefinition("http://jp.ricoh.com/Themes/DxR", "DxR.ThemePack")]
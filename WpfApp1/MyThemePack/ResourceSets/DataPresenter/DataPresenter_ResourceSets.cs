using System.ComponentModel;
using System.Reflection;
using Infragistics.Windows;
using Infragistics.Windows.Themes;

// ReSharper disable once CheckNamespace
namespace MyThemePack.ResourceSets.OrangePeel
{
    public class DataPresenter : DataPresenterResourceSet<Locator>
    {
        private static DataPresenter _instance;
        public static DataPresenter Instance => _instance ?? (_instance = new DataPresenter());
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class Locator : ResourceSetLocator
    {
        public override Assembly Assembly => this.GetType().Assembly;
        public override string Theme => "OrangePeel";
        public override string Grouping => DataPresenterGeneric.Instance.Grouping;
        public override string ResourcePath => @"ResourceSets\DataPresenter\DataPresenter.xaml";
    }
}
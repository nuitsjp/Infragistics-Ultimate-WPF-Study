using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using Infragistics.DragDrop;
using Infragistics.Windows.DataPresenter;

namespace DotNetFramework
{
    public class DragDropBehavior : Behavior<DragSource>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Drop += AssociatedObject_Drop;
            this.AssociatedObject.DragStart += AssociatedObjectOnDragStart;
        }

        private void AssociatedObjectOnDragStart(object sender, DragDropStartEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("DragStart");
        }

        private void AssociatedObject_Drop(object sender, DropEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Drop");

            var dragSource = sender as DragSource;
            var fe = dragSource.AssociatedObject as FrameworkElement;
            var record = fe.DataContext as Record;

            // XamTreeGrid の取得
            var presenter = record.DataPresenter as XamTreeGrid;

            // ドラッグレコードの取得
            var source = e.DragSource as ContentPresenter;
            var sourceRecord = source.DataContext as DataRecord;
            var sourceIndex = sourceRecord.Index;

            // ドロップレコードの取得
            var target = e.DropTarget as ContentPresenter;
            var targetRecord = target.DataContext as DataRecord;
            var targetIndex = targetRecord.Index;

            var dc = presenter.DataContext;
            var vm = dc as MainWindowViewModel;

            // ドラッグレコードの位置変更
            //vm.Tasks.Move(sourceIndex, targetIndex);
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Drop -= AssociatedObject_Drop;
            base.OnDetaching();
        }
    }
}
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using DragAndDropWithXamDataGridOnFramework.ViewModel;
using Infragistics.DragDrop;
using Infragistics.Windows.DataPresenter;

namespace DragAndDropWithXamDataGridOnFramework.Behavior
{
    public class DragDropBehavior : Behavior<DragSource>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Drop += AssociatedObject_Drop;
        }

        private void AssociatedObject_Drop(object sender, DropEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Drop");
            
            DragSource dragSource = sender as DragSource;
            FrameworkElement fe = dragSource.AssociatedObject as FrameworkElement;
            Record record = fe.DataContext as Record;

            // XamDataGrid の取得
            XamDataGrid presenter = record.DataPresenter as XamDataGrid;

            // ドラッグレコードの取得
            ContentPresenter source = e.DragSource as ContentPresenter;
            DataRecord sourceRecord = source.DataContext as DataRecord;
            int sourceIndex = sourceRecord.Index;

            // ドロップレコードの取得
            ContentPresenter target = e.DropTarget as ContentPresenter;
            DataRecord targetRecord = target.DataContext as DataRecord;
            int targetIndex = targetRecord.Index;

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

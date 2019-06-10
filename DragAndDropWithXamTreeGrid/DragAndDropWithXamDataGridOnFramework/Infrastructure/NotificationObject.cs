using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DragAndDropWithXamDataGridOnFramework.Infrastructure
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

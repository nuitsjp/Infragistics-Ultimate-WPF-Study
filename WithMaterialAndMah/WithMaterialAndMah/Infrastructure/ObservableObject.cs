using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CAS_32143_SampleApp1.Infrastructure
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        protected ObservableObject()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            // もし下記1行の?の部分でエラーが出ている場合は、下のコメント内の3行と置き換えてください。
            // https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/null-conditional-operators
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            /*
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            */
        }

    }
}

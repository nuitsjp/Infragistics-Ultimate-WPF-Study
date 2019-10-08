using CAS_32143_SampleApp1.Infrastructure;
using CAS_32143_SampleApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithMaterialAndMah
{
    public class MainWindowViewModel : ObservableObject
    {
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { _people = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel()
        {
            _people = new ObservableCollection<Person>();
            for(int i = 0; i < 5; i++)
            {
                _people.Add(new Person() { Id = i, Name = "Person " + i.ToString() });
            }
        }
    }
}

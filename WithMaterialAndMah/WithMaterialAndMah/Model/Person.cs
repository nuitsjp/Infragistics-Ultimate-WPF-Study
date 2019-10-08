using CAS_32143_SampleApp1.Infrastructure;
using System;

namespace CAS_32143_SampleApp1.Model
{
    public class Person : ObservableObject
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public Person()
        {

        }
    }
}

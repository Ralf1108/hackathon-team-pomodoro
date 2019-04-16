using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PomodoroPwaXamarin
{
    public class ListModel : BindableObject
    {
        public ICommand AddCmd => new Command (() => {
            Data.Add (Input);
            OnPropertyChanged (nameof (Data));
        });

        private string _input;

        public string Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged ();
            }
        }

        private ObservableCollection<string> _data = new ObservableCollection<string>
        {
            "entry 1",
            "entry 2",
            "entry 3",
            "entry 4"
        };

        public ObservableCollection<string> Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged ();
            }
        }
    }
}

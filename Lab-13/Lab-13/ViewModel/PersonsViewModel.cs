using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Lab_13
{
    class PersonsViewModel : INotifyPropertyChanged
    {
        private Person selectedPerson;
        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }
        public ObservableCollection<Person> Persons { get; set; }


        public PersonsViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person { FullName = "Иванов Иван Иванович", ContributionType = "Срочный вклад"},
                new Person { FullName = "Петров Петр Петрович", ContributionType = "Вклад до востребования"}
            };
        }


        private RelayCommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Person person = new Person();
                      Persons.Insert(0, person);
                      SelectedPerson = person;
                  }));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
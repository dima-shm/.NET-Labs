using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_13
{
    class Person : INotifyPropertyChanged
    {
        private string contributionType;
        private string fullName;
        public string ContributionType
        {
            get { return contributionType; }
            set
            {
                contributionType = value;
                OnPropertyChanged("ContributionType");
            }
        }
        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingExample
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
        private Person? _person;

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person { Name = "Martin Petrella", Address = "139 Hurstbourne Road", Email = "martinpetrella62@gmail.com", Age = 61 });
            Persons.Add(new Person { Name = "Kathryn McNeill", Address = "139 Hurstbourne Road", Email = "kmcneill1070@gmail.com", Age = 63 });

            foreach (var person in Persons) { person.PropertyChanged += Person_PropertyChanged; }
        }

        private void Person_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            
        }

        public ObservableCollection<Person>? Persons { get; private set; }

        public Person? Person { get { return _person; }
            set { _person = value; OnPropertyChanged("Person"); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

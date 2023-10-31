using System.ComponentModel;

namespace DataBindingExample
{
    internal class Person : INotifyPropertyChanged
    {
        private string? _name;
        private string? _address;
        private string? _email;
        private int? _age;

        public string? Name { get { return _name; } set { if (_name != value) { PropertyChanged?.Invoke(this, new PersonPropertyChangedEventArgs("Name", _name, value)); _name = value; } } }
        public string? Address { get { return _address; } set { if (_address != value) { PropertyChanged?.Invoke(this, new PersonPropertyChangedEventArgs("Address", _address, value)); _address = value; } } }
        public string? Email { get { return _email; } set { if (_email != value) { PropertyChanged?.Invoke(this, new PersonPropertyChangedEventArgs("Email", _email, value)); _email = value; } } }
        public int? Age { get { return _age; } set { if (_age != value) { PropertyChanged?.Invoke(this, new PersonPropertyChangedEventArgs("Age", _age.ToString(), value.ToString())); _age = value; } } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string? ToString() { return Name; }
    }

    internal class PersonPropertyChangedEventArgs : PropertyChangedEventArgs
    {
        public PersonPropertyChangedEventArgs(string? propertyName, string? oldValue, string? newValue) : base(propertyName)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}

using System.Collections.Generic;
using System.Windows;

namespace DataBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonViewModel _personViewModel = new PersonViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _personViewModel;
            _personViewModel.PropertyChanged += _personViewModel_PropertyChanged;
        }

        private void _personViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void PersonSelectorComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            if(PersonSelectorComboBox.Items.Count == 0)
            {

            }
            else
            {
                PersonSelectorComboBox.SelectedIndex = 0;
            }
        }

        private void PersonSelectorComboBoxSelection_Changed(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _personViewModel.Person = PersonSelectorComboBox.SelectedItem as Person;
        }
    }
}

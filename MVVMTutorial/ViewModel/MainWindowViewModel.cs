using MVVMTutorial.Model;
using MVVMTutorial.MVVM;
using System.Collections.ObjectModel;

namespace MVVMTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem(), canExecute => { return true; });
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => selectedItem != null);

        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        private Item selectedItem;

        public Item SelectedItem {
            get { return selectedItem; }
            set {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name="New Boot",
                SerialNumber="xxx9xx",
                Quantity=4
            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        // We won't implement a full save here because we're not implementing a database
        // Save to file/db functionality goes here

        private void Save()
        {
            // Save functionality 
        }

        // CanSave() here could mean: "Is the database connected?",
        // "Does the logged in user have the requisite permissions to save said item?" etc depending on your application and needs

        private bool CanSave() 
        {
            return true;
        }
    }
}

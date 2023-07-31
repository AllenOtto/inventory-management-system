using MVVMTutorial.Model;
using MVVMTutorial.MVVM;
using System.Collections.ObjectModel;

namespace MVVMTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem(), canExecute => { return true; });

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
    }
}

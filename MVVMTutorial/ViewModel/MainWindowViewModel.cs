using MVVMTutorial.Model;
using MVVMTutorial.MVVM;
using System.Collections.ObjectModel;

namespace MVVMTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();

            Items.Add(new Item
            {
                Name="Black Oxfords",
                SerialNumber="01984",
                Quantity=4
            });

            Items.Add(new Item
            {
                Name="Hublot 007",
                SerialNumber="01987",
                Quantity=2
            });

            Items.Add(new Item
            {
                Name="Designer Suit",
                SerialNumber="01989",
                Quantity=7
            });
        }

        private Item selectedItem;

        public Item SelectedItem {
            get { return selectedItem; }
            set {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
    }
}

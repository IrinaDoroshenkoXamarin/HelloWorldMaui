using System;
using FreshMvvm.Maui;
using HelloWorldMaui.Models;

namespace HelloWorldMaui.ViewModels
{
    public class HomePageModel : FreshBasePageModel
    {
        private List<ItemModel> _itemsList;
        public List<ItemModel> ItemsList
        {
            get
            {
                return _itemsList;
            }
            set
            {
                if (_itemsList != value)
                {
                    _itemsList = value;
                    RaisePropertyChanged(nameof(ItemsList));
                }
            }
        }

        public HomePageModel()
        {
            UpdateItems();
        }

        private void UpdateItems()
        {
            ItemsList = new();

            for (int i = 0; i < 101; i++)
            {
                ItemsList.Add(new ItemModel()
                {
                    Name = $"Item # {i} added",
                    IsChecked = i % 2 == 0
                });
            }
        }
    }
}


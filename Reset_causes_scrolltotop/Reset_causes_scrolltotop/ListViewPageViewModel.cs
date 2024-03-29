﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Reset_causes_scrolltotop
{
    public class ListViewPageViewModel
    {
        private static readonly IEnumerable<string> _items = Enumerable.Range(0, 50).Select(num => num.ToString());

        public ImprovedObservableCollection<string> Items { get; set; } = new ImprovedObservableCollection<string>();

        public ICommand ClearListCommand => new Command(_ => { Items.Clear(); });

        public ICommand AddRangeCommand => new Command(_ => AddRange());

        public ICommand AddRangeWithCleanCommand => new Command(_ =>
        {
            Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                AddRange();
            }


        });

        private void AddRange()
        {
            foreach (var item in _items)
            {
                Items.Add(item);
            }
        }

    }
}
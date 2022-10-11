using App1.ListDetail;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListDetailsPage : Page
    {
        public ListDetailsPage()
        {
            this.InitializeComponent();
            Items = new ObservableCollection<Detail>()
        {
            new Detail(){ID = 1, Name = "name" },
            new Detail(){ID = 2, Name = "name2" },
        };
        }

        private ObservableCollection<Detail> items;

        public ObservableCollection<Detail> Items
        {
            get => items;
            set => items = value;
        }

        private void ListDetailsView_ViewStateChanged(object sender, ListDetailsViewState e)
        {

        }
    }
}

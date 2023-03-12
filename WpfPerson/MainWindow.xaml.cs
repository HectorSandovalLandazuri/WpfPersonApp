using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,ISaveAddress
    {
        BindingList<AddressModel> addresses=new BindingList<AddressModel>();

        public MainWindow()
        {
            InitializeComponent();
            lbxAddresses.ItemsSource = addresses;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);
            entry.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                IsActive = (chkActive.IsChecked ?? false),
                Addresses = addresses.ToList()
            };   
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }
    }
}

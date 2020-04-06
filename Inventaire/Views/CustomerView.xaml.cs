﻿using app_models;
using BillingManagement.UI.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerView : Window
    //mod for initial commit
    {
        CustomerViewModel _vm;
        public CustomerView(CustomerViewModel CVM)
        {
            InitializeComponent();

            _vm = CVM;
            DataContext = CVM;
        }
        private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            _vm.Customers.Add(temp);
            _vm.SelectedCustomer = temp;
        }

        public void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = _vm.Customers.IndexOf(_vm.SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            _vm.Customers.Remove(_vm.SelectedCustomer);

            lvCustomers.SelectedIndex = currentIndex;

        }


    }  
}

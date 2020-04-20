﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Domino_Label_Production.Models;
using System.Data.Entity;

namespace Domino_Label_Production.UserControls
{
    /// <summary>
    /// Interaction logic for OrderListaUC.xaml
    /// </summary>
    public partial class OrderListaUC : UserControl
    {
        Entities context = new Entities();
        CollectionViewSource ordersViewSource;

        public OrderListaUC()
        {
            InitializeComponent();
            ordersViewSource = ((CollectionViewSource)(FindResource("ordersViewSource")));
            DataContext = this;
            
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }

            context.Orders.Load();
            
            ordersViewSource.Source = context.Orders.Local;
        }

        private void RefreshList_Click(object sender, RoutedEventArgs e)
        {
            context.Orders.Load();

            ordersViewSource.Source = context.Orders.Local;
        }

        private void SkickaTillMaskin1_Click(object sender, RoutedEventArgs e)
        {
            Orders order = (Orders)ordersDataGrid.SelectedItem;
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill skicka order: " + order.TillverkningsOrderNummer + " till maskin 1?", "Bekräfta order", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    ((MainWindow)Application.Current.MainWindow).SelectedOrderMaskin1(order);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                    break;
                case MessageBoxResult.No:
                    break;
            }
            context.Orders.Load();
            
            ordersViewSource.Source = context.Orders.Local;

        }

        private void SkickaTillMaskin2_Click(object sender, RoutedEventArgs e)
        {
            Orders order = (Orders)ordersDataGrid.SelectedItem;
            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill skicka order: " + order.TillverkningsOrderNummer + " till maskin 2?", "Bekräfta order", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    ((MainWindow)Application.Current.MainWindow).SelectedOrderMaskin2(order);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                    break;
                case MessageBoxResult.No:
                    break;
            }
            context.Orders.Load();

            ordersViewSource.Source = context.Orders.Local;
        }
    }
}

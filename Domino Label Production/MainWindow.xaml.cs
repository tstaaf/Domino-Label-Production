﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Domino_Label_Production.Models;
using Domino_Label_Production.Service;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Domino_Label_Production.UserControls;
using Domino_Label_Production.Windows;
using Domino_Label_Production.ViewModel;

namespace Domino_Label_Production
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderService service = new OrderService();
        MaskinStatus maskinStatusUC = new MaskinStatus();
        OrderListaUC orderListaUC = new OrderListaUC();
        MaskinValUC maskinval = new MaskinValUC();
        public OrderViewModel ovm = new OrderViewModel();
        bool maskinStatusView;
        public MainWindow()
        {
            InitializeComponent();
            MainView.Content = maskinStatusUC;
            maskinStatusView = true;
            service.Watch();
        }

        private void TillverkningsOrderLista_Click(object sender, RoutedEventArgs e)
        {
            //var orderListaWindow = new TillverkningsOrderListaWindow();
            //orderListaWindow.Show();
            MainView.Content = orderListaUC;
            maskinStatusView = false;

        }

        public void SelectedOrder(Orders order)
        {
            Console.WriteLine(order.ArtikelNamn);
            maskinStatusUC.artnamnLabel.Content = order.ArtikelNamn;
        }

        private void Avsluta_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimera_Click(object sender, RoutedEventArgs e)
        {
            
            if(!maskinStatusView)
            {
                MainView.Content = maskinStatusUC;
                maskinStatusView = true;
            }
            else
            {
                WindowState = WindowState.Minimized;
            }
        }

        private void Ladda_Click(object sender, RoutedEventArgs e)
        {  
            MainView.Content = maskinval;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
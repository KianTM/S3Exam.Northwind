using S3Exam.Northwind.DAL;
using S3Exam.Northwind.Entities;
using System;
using System.Collections.Generic;
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

namespace S3Exam.Northwind.Gui
{
    /// <summary>
    /// Interaction logic for OrdersUserControl.xaml
    /// </summary>
    public partial class OrdersUserControl : UserControl
    {
        private Order selectedOrder;
        private List<Order> orders;

        public OrdersUserControl()
        {
            InitializeComponent();
            DataContext = this;
            DisplayAllOrders();
        }

        private void DisplayAllOrders()
        {
            Repository repository = new Repository();
            orders = repository.GetAllOrders();
            //orders.OrderByDescending(o => o.RequiredDate).ToList();
            ordersDataGrid.ItemsSource = orders;
        }

        private void OrdersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

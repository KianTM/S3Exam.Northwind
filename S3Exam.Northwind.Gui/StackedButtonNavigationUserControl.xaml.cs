using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for StackedButtonNavigationUserControl.xaml
    /// </summary>
    public partial class StackedButtonNavigationUserControl : UserControl
    {
        MainWindow mainWindow;
        private List<ToggleButton> buttons;

        public StackedButtonNavigationUserControl(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            buttons = new List<ToggleButton>
            {
                hrButton,
                ordersButton,
                productsButton,
                earningsButton,
                customerButton,
                providerButton
            };
        }

        private void HrButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "hrButton")
                {
                    button.IsChecked = false;
                }
            }
        }

        private void OrdersButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "ordersButton")
                {
                    button.IsChecked = false;
                }
            }
            mainWindow.DetailsUserControl.Content = new OrdersUserControl();
        }

        private void ProductsButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "productsButton")
                {
                    button.IsChecked = false;
                }
            }
        }

        private void EarningsButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "earningsButton")
                {
                    button.IsChecked = false;
                }
            }
        }

        private void CustomerButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "customerButton")
                {
                    button.IsChecked = false;
                }
            }
        }

        private void ProviderButton_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsChecked == true && button.Name != "providerButton")
                {
                    button.IsChecked = false;
                }
            }
        }
    }
}

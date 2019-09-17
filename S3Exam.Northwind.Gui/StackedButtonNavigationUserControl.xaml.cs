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
            buttons = new List<ToggleButton>();
            buttons.Add(hrButton);
            buttons.Add(ordersButton);
            buttons.Add(productsButton);
            buttons.Add(earningsButton);
            buttons.Add(customerButton);
            buttons.Add(providerButton);
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
            mainWindow.DetailsUserControl.Content = new HRUserControl();
        }
    }
}

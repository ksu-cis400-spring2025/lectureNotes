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

namespace EventExample
{
    /// <summary>
    /// Interaction logic for ColorControl.xaml
    /// </summary>
    public partial class ColorControl : UserControl
    {
        //custom event
        public event EventHandler<ColorEventArgs>? ColorEvent;

        public ColorControl()
        {
            InitializeComponent();
        }

        public void ClickColor(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Name == "RedButton")
                {
                    //invoke my custom event
                    ColorEvent?.Invoke(this, new ColorEventArgs("Red"));
                }
                else if (b.Name == "BlueButton")
                {
                    //invoke my custom event
                    ColorEvent?.Invoke(this, new ColorEventArgs("Blue"));
                }
            }
        }
    }
}

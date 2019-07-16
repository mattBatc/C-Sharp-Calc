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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// View legend.txt for button and operaion numbers
    /// </summary>
    
    public partial class MainWindow : Window
    {

        CalcModel cm;
        //Boolean firstOpp for the sending the first operation button press, used to determine wether a total is calculated after the operation button press
        //Boolean firstPress for determining if the display box needs to be cleared before the new number is put in the display
        bool firstOpp,firstPress;

        public MainWindow()
        {
            InitializeComponent();
            firstOpp = true;
            firstPress = false;
            cm = new CalcModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button pressed = (Button)sender;
            String butTag = (String)pressed.Tag;
            //Console debug lines
            Console.WriteLine("Button pressed!");
            Console.WriteLine("tag = " + butTag.ToString());

            int tag = int.Parse(butTag);
            if (tag >=0 && tag <= 10)
            {
                if (firstPress)
                {
                    Console.WriteLine("Display cleared");
                    display.Text = "";
                    display.Text = tag.ToString();
                    firstPress = false;
                }
                else
                    display.Text += tag.ToString();
            }

            else if(tag >= 14 && tag <= 17)
            {
                switch (tag)
                {
                    case 14:
                        if (firstOpp == true)
                        {
                            cm.setFirstNum(Double.Parse(display.Text));
                            firstOpp = false;
                            firstPress = true;
                        }
                        else if (firstPress)
                            return;
                        else
                        {
                            cm.setSecondNumber(Double.Parse(display.Text));
                            display.Text = (cm.calculate().ToString());
                        }
                            cm.setOperation(4);
                        break;


                    case 15:
                        if (firstOpp == true)
                        {
                            cm.setFirstNum(Double.Parse(display.Text));
                            firstOpp = false;
                            firstPress = true;
                        }
                        else
                        {
                            cm.setSecondNumber(Double.Parse(display.Text));
                            display.Text = (cm.calculate().ToString());
                        }
                        cm.setOperation(5);
                        break;


                    case 16:
                        if (firstOpp == true)
                        {
                            cm.setFirstNum(Double.Parse(display.Text));
                            firstOpp = false;
                            firstPress = true;
                        }
                        else
                        {
                            cm.setSecondNumber(Double.Parse(display.Text));
                            display.Text = (cm.calculate().ToString());
                        }
                        cm.setOperation(6);
                        break;


                    case 17:
                        if (firstOpp == true)
                        {
                            cm.setFirstNum(Double.Parse(display.Text));
                            firstOpp = false;
                            firstPress = true;
                        }
                        else
                        {
                            cm.setSecondNumber(Double.Parse(display.Text));
                            display.Text = (cm.calculate().ToString());
                        }
                        cm.setOperation(7);
                        break;
                }
            }

            else
            {
                switch (tag)
                {
                    case 11:
                        display.Text = "";
                        break;
                    case 12:
                        if (display.Text.Length == 0)
                            return;
                        String text = display.Text;
                        String updated = text.Substring(0, (text.Length - 1));
                        display.Text = updated;
                        break;
                    case 13:
                        display.Text += ".";
                        break;
                    case 18:
                        cm.setSecondNumber(double.Parse(display.Text));
                        display.Text = (cm.calculate().ToString());
                        break;
                    case 19:
                        display.Text = "-" + display.Text;
                        break;

                }
            }
        }
    }
}

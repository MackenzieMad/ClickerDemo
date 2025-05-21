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

namespace ClickerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int playerDollar = 0;
        int playerGem = 0;
        public MainWindow()
        {
            
            InitializeComponent();
            lblDollarNum.Content = "0";
            lblGemNum.Content = "0";
            lblDollars.Content = "Dollars:";
            lblGems.Content = "Gems:";
            
        }

        private void btnDollarCharge_Click(object sender, RoutedEventArgs e)
        {
            DollarProgress.Value += 10;
            if(DollarProgress.Value >= 100)
            {
                DollarProgress.Value = 0;
                playerDollar += 1;
                lblDollarNum.Content = playerDollar.ToString();
                GemProgress.Value += 15;
            }
        }

        private void btnChargeGem_Click(object sender, RoutedEventArgs e)
        {
            GemProgress.Value += 5;
            if(GemProgress.Value >= 100)
            {
                GemProgress.Value = 0;
                playerGem += 1;
                lblGemNum.Content = playerGem.ToString();
            }
        }
    }
}

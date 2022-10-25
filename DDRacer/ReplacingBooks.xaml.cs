using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace DDRacer
{
    /// <summary>
    /// Interaction logic for ReplacingBooks.xaml
    /// </summary>
    public partial class ReplacingBooks : Window
    {
        public ReplacingBooks()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, RoutedEventArgs e)
        {
            Random rdm = new Random();
            int number = 0, total = 0;

            for (int i = 0; number != 27; i++)
            {
                number = rdm.Next(0, 50);
                lsbRdm.Items.Add(number);

            }
            for (int i = 0; i < lsbRdm.Items.Count; i++)
            {
                total += Convert.ToInt32(lsbRdm.Items[i].ToString());
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lsbRdm.SelectedItems.Count < 1) ;
            else
            {
                lsbuser.Items.Add(lsbRdm.SelectedItem);
                lsbRdm.Items.Remove(lsbRdm.SelectedItem);

            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lsbRdm.SelectedItems.Count < 1) ;

            else
            {
                lsbuser.Items.Remove(lsbuser.SelectedItem);
                lsbRdm.Items.Add(lsbuser.SelectedItem);
            }
        }
        private void btnRB_Click(object sender, RoutedEventArgs e)
        {


        }
        private void btnMG_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            minigame mg = new minigame();
            mg.ShowDialog();

        }
        private void lsbRdm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ArrayList list = new ArrayList();

            foreach (object o in lsbuser.Items)
            {
                list.Add(o);
            }
            list.Sort();
            //list.Reverse();
            lsbuser.Items.Clear();
            foreach (object o in list)
            {
                lsbuser.Items.Add(o);
            }
        }
        private void lsbuser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnMiniGame(object sender, RoutedEventArgs e)
        {

        }

        private void btnReplacingBooks_Click(object sender, RoutedEventArgs e)
        {
            ReplacingBooks rb = new ReplacingBooks();
            rb.ShowDialog();

        }
    }
}

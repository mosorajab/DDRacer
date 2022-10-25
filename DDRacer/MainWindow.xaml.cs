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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DDRacer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnGen_Click(object sender, RoutedEventArgs e)
        {
            //Random rdm = new Random();
            //int number = 0, total = 0;
            //for (int i = 0; number != 5; i++)
            //{
            //    number = rdm.Next(0, 50);
            //    lsbRdm.Items.Add(number);
            //}
            //for (int i = 0; i < lsbRdm.Items.Count; i++)
            //{
            //    total += Convert.ToInt32(lsbRdm.Items[i].ToString());
            //}
            //foreach (float i in Enumerable.Range(200000, 200).Select(d => d / 1000f))
            //{
            //   lsbRdm.Items.Add(i + "s")
            //}
            //  Random rannum = new Random();
            //cnum1= rannum.Next(100, 999);


            //for generating random numbers and letters added to the end 

            foreach (float i in Enumerable.Range(0, 10).Select(d => d / 1000f))
            {
                string auth, item;
            Random author = new Random();

            const string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            auth = new string(Enumerable.Range(1, 3).Select(_ => letter
            [author.Next(10, letter.Length)]).ToArray()); 

                Random rdm = new Random();
                float rdmf, rdmf1;
                rdmf = rdm.Next(000, 999);
                rdmf1 = rdm.Next(000, 999);

                lsbRdm.Items.Add(rdmf + "." +rdmf1+auth);    

            }
            //https://youtu.be/CwMs6kyaXkE
            //Generate Sequence of Float Numbers within a Range using C#
            //Author - CodersMedi 
            //Accessed 17 September 2022
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            //move items from the generated list box to users selection 
           
                lsbuser.Items.Add(lsbRdm.SelectedItem);
                lsbRdm.Items.Remove(lsbRdm.SelectedItem);
           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            lsbRdm.Items.Add(lsbuser.SelectedItem);
                lsbuser.Items.Remove(lsbuser.SelectedItem);

           //https://youtu.be/8KjE9q077dU
           //Author - GnsCode
           //ListBox Sort One Item and Move One Or Multiple items in c# sharp
           //Accesed - 19 Sept 2022

        }
        private void btnRB_Click(object sender, RoutedEventArgs e)
        {
           
            
        }
        private void btnMG_Click(object sender, RoutedEventArgs e)
        {
          
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        { //to show the mini game on button click 
            minigame mg = new minigame();
            mg.ShowDialog();
        }
        private void lsbRdm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //sorting the data in the users selection listbox 
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //to clear items in list box 
            lsbuser.Items.Clear();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //to clear items in list box 
            lsbRdm.Items.Clear();
        }

        private void btnIdentifyingareas_Click(object sender, RoutedEventArgs e)
        {
           IdentifyingAreas ia = new IdentifyingAreas();
            ia.ShowDialog(); 

        }

        private void btnFindingcallnumbers_Click(object sender, RoutedEventArgs e)
        {
           FindCallNums fcn = new FindCallNums();
            fcn.ShowDialog();
        }
    }
    }


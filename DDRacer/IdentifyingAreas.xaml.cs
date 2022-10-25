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
using System.Windows.Shapes;

namespace DDRacer
{
    /// <summary>
    /// Interaction logic for IdentifyingAreas.xaml
    /// </summary>
    public partial class IdentifyingAreas : Window
    {
        public object RandomHandler { get; private set; }

       
        public IdentifyingAreas()
        {
            InitializeComponent();
            setUpDict();
             
        }

        private void setUpDict()
        {
            //Random RandomClass = new Random();
            //List<TextBox> textboxes = new List<TextBox>() { txb1, txb2, txb3, txb4 };
            //textboxes.ForEach(x => x.Text = RandomClass.Next(0, 9).ToString() + RandomClass.Next(00, 100).ToString());



            Dictionary<string, string> Dewey = new Dictionary<string, string>();
            Dewey.Add("000", "Generalities"); //adding a key/value using the Add() method
            Dewey.Add("100", "Philisophy");
            Dewey.Add("200", "Religion");
            Dewey.Add("300", "Social Sciences");
            Dewey.Add("400", "Languages");
            Dewey.Add("500", "Science");
            Dewey.Add("600", "Technology");
            Dewey.Add("700", "Arts");
            Dewey.Add("800", "Literature");
            Dewey.Add("900", "History/Geography");


            //random categories 
            Random RandomClass2 = new Random();
          List<TextBox> txbDewey = new List<TextBox>() { txbD1, txbD2, txbD3, txbD4, txbD5, txbD6, txbD7 };
          var lines = Dewey.Select(kv => kv.Value.ToString());
          txbDewey.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);
           
            
             //random call numbers
           List<TextBox> textbox = new List<TextBox>() { txb1, txb2, txb3, txb4 };
           var lines1 = Dewey.Select(kv => kv.Key.ToString());
           textbox.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Key);


            //cmb1.Items.Add(Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);
            //cmb1.Items.Add(Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);




            /*
            foreach (KeyValuePair<string, string> mix in Dewey)
            {
              // List<TextBox> txbDewey = new List<TextBox>() { txbD1, txbD2, txbD3, txbD4, txbD5, txbD6, txbD7 };
                var lines = Dewey.Select(kv => kv.Value.ToString());
               // txbDewey.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);
                List<TextBox> textbox = new List<TextBox>() { txb1, txb2, txb3, txb4 };
                var lines1 = Dewey.Select(kv => kv.Key.ToString());
               // textbox.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Key + RandomClass2.Next(10, 99).ToString());



            }*/


            //List<TextBox> txbDewey = new List<TextBox>() { txbD1, txbD2, txbD3, txbD4, txbD5, txbD6, txbD7 };

            //while (txbDewey.Count <4)
            //{
            //    RandomClass = RandomHandler.rnd.Next(10); 

            //    if (!txbDewey.Contains(Dewey.ElementAt(RandomClass).Key.ToString("0")))
            //    {

            //    }

            //}


            //foreach (KeyValuePair<int, string> kvp in Dewey)
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //random call numbers 
            //  Random RandomClass = new Random();
            //List<TextBox> textboxes = new List<TextBox>() { txb1, txb2, txb3, txb4};
            //var lines1 = Dewey.Select(kv => kv.Key.ToString());
            //textboxes.ForEach(x => x.Text = Dewey.ElementAt(RandomClass.Next(0, Dewey.Count)).Key + RandomClass.Next(10, 99).ToString());


            //Random rand = new Random();
            //return Dewey.ElementAt(rand.Next(0, Dewey.Count)).Value;

            //var lines = Dewey.Select(kv => kv.Key + kv.Value.ToString());
            //var lines = Dewey.Select(kv => kv.Value.ToString());
            //txbD1.Text = string.Join(Environment.NewLine, lines);

            var choices = new Dictionary<string, string>();
            choices["A"] = "Arthur";
            choices["F"] = "Ford";
            choices["T"] = "Trillian";
            choices["Z"] = "Zaphod";
            var liness = Dewey.Select(kv => kv.Value.ToString());
          
          


        }

        private void cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Random RandomClass = new Random();
            //Control[] textboxes = new Control[] { txb1, txb2, txb3, txb4};
            //foreach (Control c in textboxes)
            //    c.Text = RandomClass.Next(0, 9).ToString();

            //Random RandomClass = new Random();
            //List<TextBox> textboxes = new List<TextBox>() { txb1, txb2, txb3, txb4 };
            //textboxes.ForEach(x => x.Text = RandomClass.Next(0, 10).ToString());
        }

        private void txbD1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {

            Dictionary<string, string> Dewey = new Dictionary<string, string>();
            Dewey.Add("000", "General knowledge"); //adding a key/value using the Add() method
            Dewey.Add("100", "Philisophy");
            Dewey.Add("200", "Religion");
            Dewey.Add("300", "Social Sciences");
            Dewey.Add("400", "Languages");
            Dewey.Add("500", "Science");
            Dewey.Add("600", "Technology");
            Dewey.Add("700", "Arts");
            Dewey.Add("800", "Literature");
            Dewey.Add("900", "History & Geography");

            Random RandomClass2 = new Random();
            List<TextBox> txbDewey = new List<TextBox>() { txbD1, txbD2, txbD3, txbD4, txbD5, txbD6, txbD7 };
            var lines = Dewey.Select(kv => kv.Key.ToString());
            txbDewey.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Key);


            //random call numbers
            List<TextBox> textbox = new List<TextBox>() { txb1, txb2, txb3, txb4 };
            var lines1 = Dewey.Select(kv => kv.Value.ToString());
            textbox.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);

            lbl1.Content = "Dewey Categories";
            lbl2.Content = "Call Numbers";

        }

        private void btnSwitchBack_Click(object sender, RoutedEventArgs e)
        {

            Dictionary<string, string> Dewey = new Dictionary<string, string>();
            Dewey.Add("000", "General knowledge"); //adding a key/value using the Add() method
            Dewey.Add("100", "Philisophy");
            Dewey.Add("200", "Religion");
            Dewey.Add("300", "Social Sciences");
            Dewey.Add("400", "Languages");
            Dewey.Add("500", "Science");
            Dewey.Add("600", "Technology");
            Dewey.Add("700", "Arts");
            Dewey.Add("800", "Literature");
            Dewey.Add("900", "History & Geography");

            


            //random categories 
            Random RandomClass2 = new Random();
            List<TextBox> txbDewey = new List<TextBox>() { txbD1, txbD2, txbD3, txbD4, txbD5, txbD6, txbD7 };
            var lines = Dewey.Select(kv => kv.Value.ToString());
            txbDewey.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Value);


            //random call numbers
            List<TextBox> textbox = new List<TextBox>() { txb1, txb2, txb3, txb4 };
            var lines1 = Dewey.Select(kv => kv.Key.ToString());
            textbox.ForEach(x => x.Text = Dewey.ElementAt(RandomClass2.Next(0, Dewey.Count)).Key);

            lbl1.Content = "Call Numbers";
            lbl2.Content = "Dewey Categories";

        }

        private void cp1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD1.Text);
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            txbA1.Text = Clipboard.GetText();
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            txbA2.Text = Clipboard.GetText();
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            txbA3.Text = Clipboard.GetText();
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            txbA4.Text = Clipboard.GetText();
        }

        private void cp2_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD2.Text);
        }

        private void cp3_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD3.Text);
        }

        private void cp4_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD4.Text);
        }

        private void cp5_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD5.Text);
        }

        private void cp6_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD6.Text);
        }

        private void cp7_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbD7.Text);
        }

        private void cl1_Click(object sender, RoutedEventArgs e)
        {
            txbA1.Clear();
        }

        private void cl2_Click(object sender, RoutedEventArgs e)
        {
            txbA2.Clear();
        }

        private void cl3_Click(object sender, RoutedEventArgs e)
        {
            txbA3.Clear();
        }

        private void cl4_Click(object sender, RoutedEventArgs e)
        {
            txbA4.Clear();
        }

        private void cpNoMatch_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txbNoA.Text);
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {

            Dictionary<string, string> Dewey = new Dictionary<string, string>();
            Dewey.Add("000", "General knowledge"); //adding a key/value using the Add() method
            Dewey.Add("100", "Philisophy");
            Dewey.Add("200", "Religion");
            Dewey.Add("300", "Social Sciences");
            Dewey.Add("400", "Languages");
            Dewey.Add("500", "Science");
            Dewey.Add("600", "Technology");
            Dewey.Add("700", "Arts");
            Dewey.Add("800", "Literature");
            Dewey.Add("900", "History & Geography");

            if(Dewey[txbA1.Text].SequenceEqual(txb1.Text))
            {
                MessageBox.Show("Match Correct in Selection 1");
            }
            else
            {
                MessageBox.Show("Match Incorrect in Selection 1");
            }

            if (Dewey[txbA2.Text].Equals(txb1.Text))
            {
                MessageBox.Show("Match Correct in Selection 2");
            }
            else
            {
                MessageBox.Show("Match Incorrect in Selection 2");
            }

            if (Dewey[txbA3.Text].Equals(txb1.Text))
            {
                MessageBox.Show("Match Correct in Selection 3");
            }
            else
            {
                MessageBox.Show("Match Incorrect in Selection 3");
            }

            if (Dewey[txbA4.Text].Equals(txb1.Text))
            {
                MessageBox.Show("Match Correct in Selection 4");
            }
            else
            {
                MessageBox.Show("Match Incorrect in Selection 4");
            }


        }
    }
}

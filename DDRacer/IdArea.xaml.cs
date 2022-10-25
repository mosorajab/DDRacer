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
    /// Interaction logic for IdArea.xaml
    /// </summary>
    public partial class IdArea : Window
    {
        public IdArea()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> matching = new List<string>
            {
                "0","GK",
                "1","P&P",
                "2","R",
                "3","SS",
                "4","L",
                "5","S",
                "6","T",
                "7","A&R",
                "8","L",
                "9","H&G",

            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(matching.Count);
                string nextMatch = matching[index];
                textBlock.Text = nextMatch;
                matching.RemoveAt(index); 
            }
        }
    }
}

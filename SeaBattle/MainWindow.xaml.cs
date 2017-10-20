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
using System.Xml;
using SeaBattle.Controls; 
using System.Xml.Linq;
using SeaBattle.Service;

namespace SeaBattle
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            int size = EnemyField.Size;

            List<Tuple<int, int,int>> tmp = new List<Tuple<int, int,int>>();

            for (int i = 0; i < EnemyField.Size; i++)
            {
                int x , y ,state;

                for (int j = 0; j < EnemyField.Size; j++)
                {
                    var cell = EnemyField[i, j];

                    x = (cell.X - 1);

                    y = (cell.Y - 1);

                    state = (cell.State == CellState.Missed ? (int)CellState.Ship : (int)CellState.None);

                    tmp.Add(Tuple.Create(x, y, state));
                }

            }

         
           UnitOfWork.Instance.BattlefieldService.SaveToXML(tmp,size); 
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
             
            var res = UnitOfWork.Instance.BattlefieldService.LoadFromXML();

            foreach (Tuple<int,int,int> tmp in res)
            {
                
                var cell = EnemyField[tmp.Item2, tmp.Item1];
                cell.X = tmp.Item1;
                cell.Y = tmp.Item2;
                cell.State = (CellState)tmp.Item3;
            }
        }
    }
}

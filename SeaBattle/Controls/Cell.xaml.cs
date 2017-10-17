using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SeaBattle.Controls
{
    /// <summary>
    /// Interaction logic for Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        private CellState _state;
        private int _x;
        private int _y;
        private Field _field;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public CellState State { get => _state; set => _state = value; }

        public Cell(Field field, int X, int Y)
        {
            InitializeComponent();
            _field = field;
            _x = X;
            _y = Y;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!_field.IsEnemy) return;
            ;
            MyGrid.Background = Brushes.Aqua;
        }

        private void MyGrid_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (!_field.IsEnemy) return;
            MyGrid.Background = GetColor();
        }

        private void MyGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!_field.IsEnemy) return;

            if (_state == CellState.Ship)
                _state = CellState.Damage;
            else if (_state != CellState.Damage)
                _state = CellState.Missed;

            MyGrid.Background = GetColor();
        }

        private Brush GetColor()
        {
            switch (_state)
            {
                case CellState.Damage:
                    return Brushes.Red;
                case CellState.Missed:
                    return Brushes.Green;
                case CellState.None:
                    return Brushes.Blue;
                case CellState.Ship:
                    return Brushes.Blue;
                default:
                    return Brushes.Blue;
            }
        }
    }

    public enum CellState
    {
        None = 0,
        Ship = 1,
        Damage = 2,
        Missed = 3
    }
}

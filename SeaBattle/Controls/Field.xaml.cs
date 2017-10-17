using System.Windows;
using System.Windows.Controls;

namespace SeaBattle.Controls
{
    /// <summary>
    /// Interaction logic for Field.xaml
    /// </summary>
    public partial class Field : Grid
    {
        public static readonly DependencyProperty EnemyDependencyProperty = DependencyProperty.Register("IsEnemy", typeof(bool), typeof(Field));

        private Cell[,] _cells;
        private int _size = 10;

        public Cell[,] Cells => _cells;
        public bool IsEnemy
        {
            get => (bool) GetValue(EnemyDependencyProperty);
            set => SetValue(EnemyDependencyProperty, value);
        }
        public int Size => _size;

        public Cell this[int i, int j] => _cells[i, j];

        public Field()
        {
            InitializeComponent();
            BuildGrid();
            BuildFiled();
        }

        private void BuildFiled()
        {
            _cells = new Cell[_size, _size];

            for (int i = 0; i < _size; i++)
            {
                var hr = new Label
                {
                    Content = (char)('A' + i),
                    Width = 25,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                var vr = new Label
                {
                    Content = i + 1,
                    Width = 25,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                for (int j = 0; j < _size; j++)
                {

                    var cell = new Cell(this, j + 1, i + 1)
                    {
                        Height = 25,
                        Width = 25,
                        Margin = new Thickness(1)
                    };

                    _cells[i, j] = cell;

                    Grid.SetColumn(cell, j + 1);
                    Grid.SetRow(cell, i + 1);

                    Children.Add(cell);
                }
                Grid.SetRow(hr, 0);
                Grid.SetColumn(hr, i + 1);

                Grid.SetRow(vr, i + 1);
                Grid.SetColumn(vr, 0);

                Children.Add(vr);
                Children.Add(hr);
            }
        }

        private void BuildGrid()
        {
            for (int i = 0; i <= _size; i++)
            {
                var rowDef = new RowDefinition
                {
                    Height = GridLength.Auto
                };
                var colDef = new ColumnDefinition
                {
                    Width = GridLength.Auto
                };

                RowDefinitions.Add(rowDef);
                ColumnDefinitions.Add(colDef);
            }
        }
    }
}

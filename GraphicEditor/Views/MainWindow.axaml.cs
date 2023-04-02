using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Controls.Shapes;
using GraphicEditor.ViewModels;

namespace GraphicEditor.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}
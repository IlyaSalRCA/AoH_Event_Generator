using Avalonia.Controls;
using EventGenerator_2.ViewModels;

namespace EventGenerator_2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}

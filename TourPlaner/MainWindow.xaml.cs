using System.Windows;

namespace TourPlaner;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void About_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Tour Planner Application / SWEN2 PROJECT 2025\nBuild V0.2 - 23.02.2025\n\nDeveloped by Ivo Radic & Wendelin Windhager", "About Tour Planner", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
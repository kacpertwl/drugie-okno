using Avalonia.Controls;

namespace okno;

public partial class MainWindow : Window
{
    private int _clickCount = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _clickCount++;
        SubtitleText.Text = $"Przycisk kliknięty {_clickCount} razy!";
    }
}
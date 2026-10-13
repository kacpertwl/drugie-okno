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
        var name = string.IsNullOrWhiteSpace(InputBox.Text) ? "Gość" : InputBox.Text.Trim();
        SubtitleText.Text = $"Witaj, {name}! Kliknięto: {_clickCount}";
    }
}
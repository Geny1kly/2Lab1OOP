using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2Lab1OOP;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(Uri url)
    {
        InitializeComponent();
        var imageBrush = new ImageBrush();
        imageBrush.ImageSource = new BitmapImage(url);
        imageBrush.Stretch = Stretch.UniformToFill;
        Grid_Main.Background = imageBrush;
    }

    private void Button_Calculate_OnClick(object sender, RoutedEventArgs even)
    {
        double.TryParse(TextBox_InputE.Text, out var e);
        double.TryParse(TextBox_InputX.Text, out var x);
        double.TryParse(TextBox_InputA.Text, out var a);
        double.TryParse(TextBox_InputB.Text, out var b);
        TextBox_Result.Text = Calculations.F(e, x, a, b).ToString();
    }
}
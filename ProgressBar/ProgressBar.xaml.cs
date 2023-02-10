using ProgressBar.ProgressBarComp;

namespace ProgressBar;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class ProgressBar : Window
{
    private ProgressBar()
    {
        InitializeComponent();
    }

    public static ProgressBar FromContext(IProgressProvider context) =>
        new()
        {
            bar =
            {
                DataContext = context
            }
        };
}
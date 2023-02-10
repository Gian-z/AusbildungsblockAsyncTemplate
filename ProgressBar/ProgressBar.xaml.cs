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

    public static ProgressBar FromContext(IProgressProvider context)
    {
        var pb = new ProgressBar();
        pb.DataContext = context;
        return pb;
    }
}
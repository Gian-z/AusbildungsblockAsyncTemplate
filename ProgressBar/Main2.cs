using ProgressBar.BackgroundTasks;
using ProgressBar.Middleware;

namespace ProgressBar;

public class Main2
{
    public static void Main()
    {
        
        StartBackgroundWork();
    }

    private static void StartBackgroundWork()
    {
        var pp = new ProgressProvider();
        ProgressBar.FromContext(pp).ShowDialog();

        new PrimeNumberSummator().Summate(pp.Progress);
    }
}
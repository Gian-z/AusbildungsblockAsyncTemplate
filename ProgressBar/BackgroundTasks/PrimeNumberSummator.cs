using System;
using System.Threading.Tasks;
using ProgressBar.ProgressBarComp;

namespace ProgressBar.BackgroundTasks;

public class PrimeNumberSummator
{
    public async Task Summate(IProgress<int> progress)
    {
        for (int i = 0; i < 100; i++)
        {
            progress.Report(i);
            await Task.Delay(100);
        }
    }
}
using System;
using ProgressBar.ProgressBarComp;

namespace ProgressBar.Middleware;

public class ProgressProvider : IProgressProvider
{
    public ProgressProvider()
    {
        Progress = new Progress<int>();
        Progress.ProgressChanged += (sender, i) =>
        {
            CurrentValue = i;
        };
    }
    
    public Progress<int> Progress { get; }
    public int CurrentValue { get; private set; }
}
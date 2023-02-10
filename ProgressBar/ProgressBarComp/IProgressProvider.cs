using System;

namespace ProgressBar.ProgressBarComp;

public interface IProgressProvider
{
    public Progress<int> Progress { get; }
    
    public int CurrentValue { get; }
}
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;

namespace ProgressBar.ProgressBarComp;

public partial class Bar : UserControl
{
    public Bar()
    {
        InitializeComponent();

        var geo = Geometry.Parse("M 0,0 l 150,0 0,10 -150,0 z");
        var skewT = new SkewTransform(45, 0);
        var geoClone = geo.Clone();

        geoClone.Transform = skewT;

        var result = geoClone.GetFlattenedPathGeometry(0.001, ToleranceType.Relative).ToString(CultureInfo.InvariantCulture);
        Trace.WriteLine(this + ": " + result);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace cn.onekit.weixin.ui
{
    public sealed partial class MatchMedia : UserControl
    {
        public MatchMedia()
        {
            this.InitializeComponent();
        }
        new public double MinWidth { get; set; }
        new public double MaxWidth { get; set; }
        new public double Width { get; set; }
        new public double MinHeight { get; set; }
        new public double MaxHeight { get; set; }
        new public double Height { get; set; }
        public string Orientation { get; set; }
    }
}

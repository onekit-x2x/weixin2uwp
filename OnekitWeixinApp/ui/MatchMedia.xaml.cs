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
         public double minWidth { get; set; }
         public double maxWidth { get; set; }
         public double width { get; set; }
         public double minHeight { get; set; }
         public double maxHeight { get; set; }
         public double height { get; set; }
        public string orientation { get; set; }
    }
}

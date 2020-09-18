using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
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
    public sealed partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            this.InitializeComponent();
        }
        public string Title { get; set; }
        new public bool Loading { get; set; }
        public string FrontColor { get; set; }
        public string BackgroundColor { get; set; }
        public double ColorAnimationDuration { get; set; }
        [DefaultValue("linear")]
        public string ColorAnimationTimingFunc { get; set; }
    }
}

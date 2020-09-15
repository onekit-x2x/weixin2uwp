using System;
using System.Collections.Generic;
using System.ComponentModel;
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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace cn.onekit.weixin.ui
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ScrollView : Page
    {
        public ScrollView()
        {
            this.InitializeComponent();
        }
        public bool scrollX { get; set; }
        public bool scrollY { get; set; }
        [DefaultValue(50)]
        public double upperThreshold { get; set; }
        [DefaultValue(50)]
        public double lowerThreshold { get; set; }
        public double scrollTop { get; set; }
        public double scrollLeft { get; set; }
        public double lowerThreshold { get; set; }
    }
}

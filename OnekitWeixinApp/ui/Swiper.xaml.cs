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
    public sealed partial class Swiper : Page
    {
        public Swiper()
        {
            this.InitializeComponent();
        }
        public bool IndicatorDots { get; set; }
        [DefaultValue("rgba(0, 0, 0, .3)")]
        public string IndicatorColor { get; set; }
        [DefaultValue("#000000")]
        public string IndicatorActiveColor { get; set; }
        public bool Autoplay { get; set; }
        [DefaultValue(0)]
        public double Current { get; set; }
        [DefaultValue(5000)]
        public double Interval { get; set; }
        [DefaultValue(500)]
        public double Duration { get; set; }
        public bool Circular { get; set; }
        public bool Vertical { get; set; }
        [DefaultValue("0px")]
        public string PreviousMargin { get; set; }
        [DefaultValue("0px")]
        public double NextMargin { get; set; }
        public double SnapToEdge { get; set; }
        [DefaultValue(1)]
        public double DisplayMultipleItems { get; set; }
        [DefaultValue("default")]
        public string EasingFunction { get; set; }

        public EventHandler bindchange { get; set; }
        public EventHandler bindtransition { get; set; }
        public EventHandler bindanimationfinish { get; set; }
    }
}

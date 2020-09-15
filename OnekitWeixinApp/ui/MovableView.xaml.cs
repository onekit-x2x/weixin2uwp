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
    public sealed partial class MovableView : Page
    {
        public MovableView()
        {
            this.InitializeComponent();
        }
        [DefaultValue("none")]
        public string Direction { get; set; }
        public bool Inertia { get; set; }
        public string OutOfBounds { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        [DefaultValue(20)]
        public double Damping { get; set; }
        [DefaultValue(2)]
        public double Friction { get; set; }
        public bool Disabled { get; set; }
        new  public double Scale { get; set; }
        [DefaultValue(0.5)]
        public double ScaleMin { get; set; }
        [DefaultValue(10)]
        public double DcaleMax { get; set; }
        [DefaultValue(1)]
        public double DcaleValue { get; set; }
        [DefaultValue(true)]
        public bool Animation { get; set; }

        public EventHandler bindchange { get; set; }
        public EventHandler bindscale { get; set; }
        public EventHandler htouchmove { get; set; }
        public EventHandler vtouchmove { get; set; }
    }
}

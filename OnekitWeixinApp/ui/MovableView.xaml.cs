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
        public string direction { get; set; }
        public bool inertia { get; set; }
        public string outOfBounds { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        [DefaultValue(20)]
        public double damping { get; set; }
        [DefaultValue(2)]
        public double friction { get; set; }
        public bool disabled { get; set; }
        public double scale { get; set; }
        [DefaultValue(0.5)]
        public double scaleMin { get; set; }
        [DefaultValue(10)]
        public double scaleMax { get; set; }
        [DefaultValue(1)]
        public double scaleValue { get; set; }
        [DefaultValue(true)]
        public bool animation { get; set; }

        public EventHandler onChange;
        public EventHandler onScale;
        public EventHandler onHtouchmove;
        public EventHandler onVtouchmove;
    }
}

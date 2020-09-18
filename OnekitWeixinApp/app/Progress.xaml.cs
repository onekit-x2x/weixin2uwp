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

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace cn.onekit.weixin.ui
{
    public sealed partial class Progress : UserControl
    {
        public Progress()
        {
            this.InitializeComponent();
        }
        public double Percent { get; set; }
        public bool ShowInfo { get; set; }
        [DefaultValue(0)]
        public double BorderRadius { get; set; }
        [DefaultValue(16)]
        public double FontDize { get; set; }
        [DefaultValue(6)]
        public double StrokeWidth { get; set; }
        [DefaultValue("#09BB07")]
        public double Color { get; set; }
        [DefaultValue("#09BB07")]
        public double ActiveColor { get; set; }
        [DefaultValue("#EBEBEB")]
        public double BackgroundColor { get; set; }
        public bool Active { get; set; }
        [DefaultValue("backwards")]
        public string ActiveMode { get; set; }
        [DefaultValue(30)]
        public double Duration { get; set; }
        public EventHandler bindactiveend { get; set; }
    }
}

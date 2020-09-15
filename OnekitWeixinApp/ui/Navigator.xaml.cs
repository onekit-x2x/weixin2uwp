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
    public sealed partial class Navigator : UserControl
    {
        public Navigator()
        {
            this.InitializeComponent();
        }
        [DefaultValue("self")]
        public string Target { set; get; }
        public string Url { set; get; }
        [DefaultValue("navigate")]
        public string OpenType { set; get; }
        [DefaultValue(1)]
        public string Delta { set; get; }
        public string AppId { set; get; }
        public string Path { set; get; }
        public object ExtraData { set; get; }
        [DefaultValue("release")]
        public string Version { set; get; }
        [DefaultValue("navigator-hover")]
        public string HoverClass { set; get; }
        public bool HoverStopPropagation { set; get; }
        [DefaultValue(50)]
        public double hoverStartTime { set; get; }
        [DefaultValue(600)]
        public double hoverStayTime { set; get; }
        public string bindsuccess { set; get; }
        public string bindfail { set; get; }
        public string bindcomplete { set; get; }
    }
}

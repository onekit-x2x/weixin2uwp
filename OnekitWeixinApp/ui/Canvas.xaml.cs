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
    public sealed partial class Canvas : UserControl
    {
        public Canvas()
        {
            this.InitializeComponent();
        }
        public string Type { set; get; }
        public string CanvasId { set; get; }
        public bool DisableScroll { set; get; }
        public EventHandler bindtouchstart { get; set; }
        public EventHandler bindtouchmove { get; set; }
        public EventHandler bindtouchend { get; set; }
        public EventHandler bindtouchcancel { get; set; }
        public EventHandler bindlongtap { get; set; }
        public EventHandler binderror { get; set; }
    }
}

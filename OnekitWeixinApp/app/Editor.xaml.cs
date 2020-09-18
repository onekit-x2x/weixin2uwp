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
    public sealed partial class Editor : UserControl
    {
        public Editor()
        {
            this.InitializeComponent();
        }
        public bool ReadOnly { get; set; }
        public bool Placeholder { get; set; }
        public bool ShowImgSize { get; set; }
        public bool ShowImgToolbar { get; set; }
        public bool ShowImgResize { get; set; }
        public EventHandler bindready { get; set; }
        public EventHandler bindfocus { get; set; }
        public EventHandler bindblur { get; set; }
        public EventHandler bindinput { get; set; }
        public EventHandler bindstatuschange { get; set; }
    }
}

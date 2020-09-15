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
    public sealed partial class PageMeta : UserControl
    {
        public PageMeta()
        {
            this.InitializeComponent();
        }
        public string BackgroundTextStyle { get; set; }
        public string BackgroundColor{ get; set; }
        public string BackgroundColorTop { get; set; }
        public string BackgroundColorBottom { get; set; }
        public string RootBackgroundColor { get; set; }
        public string ScrollTop { get; set; }
        [DefaultValue(300)]
        public double ScrollDuration { get; set; }
        public string PageStyle { get; set; }
        public string BodyFontSize { get; set; }
        public string RootFontSize { get; set; }
        public string PageOrientation { get; set; }
        public EventHandler bindresize { get; set; }
        public EventHandler bindscroll { get; set; }
        public EventHandler bindscrolldone { get; set; }
    }
}

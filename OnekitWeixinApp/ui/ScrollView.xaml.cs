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
        public bool ScrollX { get; set; }
        public bool ScrollY { get; set; }
        [DefaultValue(50)]
        public double UpperThreshold { get; set; }
        [DefaultValue(50)]
        public double LowerThreshold { get; set; }
        public double ScrollTop { get; set; }
        public double ScrollLeft { get; set; }
        public string ScrollIntoView { get; set; }
        public bool ScrollWithAnimation { get; set; }
        public bool EnableBackToTop { get; set; }
        public bool EnableFlex { get; set; }
        public bool ScrollAnchoring { get; set; }
        public bool RefresherEnabled { get; set; }
        [DefaultValue(45)]
        public string RefresherThreshold { get; set; }
        [DefaultValue("black")]
        public string RefresherDefaultStyle { get; set; }
        [DefaultValue("#FFF")]
        public bool RefresherBackground { get; set; }
        public bool RefresherTriggered { get; set; }
        public bool Enhanced { get; set; }
        [DefaultValue(true)]
        public bool Bounces { get; set; }
        [DefaultValue(true)]
        public bool ShowScrollbar { get; set; }
        public bool PagingEnabled { get; set; }
        public bool FastDeceleration { get; set; }
        public EventHandler binddragstart { get; set; }
        public EventHandler binddragging { get; set; }
        public EventHandler binddragend { get; set; }
        public EventHandler bindscrolltoupper { get; set; }
        public EventHandler bindscrolltolower { get; set; }
        public EventHandler bindscroll { get; set; }
        public EventHandler bindrefresherpulling { get; set; }
        public EventHandler bindrefresherrefresh { get; set; }
        public EventHandler bindrefresherabort { get; set; }
        public EventHandler bindrefresherrestore { get; set; }
        public EventHandler bindDragging { get; set; }
    }
}

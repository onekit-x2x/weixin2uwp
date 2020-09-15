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
    public sealed partial class FunctionalPageNavigator : UserControl
    {
        public FunctionalPageNavigator()
        {
            this.InitializeComponent();
        }
        [DefaultValue("release")]
        public string Version { get; set; }
        new public string Name { get; set; }
        public object Args { get; set; }
        public EventHandler bindsuccess { get; set; }
        public EventHandler bindfail { get; set; }
        public EventHandler bindcancel { get; set; }
    }
}

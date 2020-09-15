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
    public sealed partial class OpenData : UserControl
    {
        public OpenData()
        {
            this.InitializeComponent();
        }
        public string Type { get; set; }
        public string OpenGid { get; set; }
        [DefaultValue("en")]
        public string Lang { get; set; }
        public string DefaultText { get; set; }
        public string DefaultAvatar { get; set; }
        public EventHandler binderror { get; set; }
    }
}

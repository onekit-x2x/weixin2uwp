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
    public sealed partial class VoipRoom : UserControl
    {
        public VoipRoom()
        {
            this.InitializeComponent();
        }
        public string Openid { get; set; }
        [DefaultValue("camera")]
        public string Mode { get; set; }
        [DefaultValue("front")]
        public string DevicePosition { get; set; }
        public EventHandler binderror { get; set; }
    }
}

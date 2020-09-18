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
    public sealed partial class Camera : UserControl
    {
        public Camera()
        {
            this.InitializeComponent();
        }
        [DefaultValue("normal")]
        public string Mode { set; get; }
        [DefaultValue("medium")]
        public string Resolution { set; get; }
        [DefaultValue("back")]
        public string DevicePosition { set; get; }
        [DefaultValue("auto")]
        public string Flash { set; get; }
        [DefaultValue("medium")]
        public string FrameSize { set; get; }
        public EventHandler bindstop { set; get; }
        public EventHandler binderror { set; get; }
        public EventHandler bindinitdone { set; get; }
    }
}

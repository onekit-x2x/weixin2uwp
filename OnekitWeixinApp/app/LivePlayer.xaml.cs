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
    public sealed partial class LivePlayer : UserControl
    {
        public LivePlayer()
        {
            this.InitializeComponent();
        }
        public string Src { get; set; }
        [DefaultValue("live")]
        public string Mode { get; set; }
        public bool Autoplay { get; set; }
        public bool Muted { get; set; }
        [DefaultValue("vertical")]
        public string Orientation { get; set; }
        [DefaultValue("contain")]
        public string ObjectFit { get; set; }
        public bool BackgroundMute { get; set; }
        [DefaultValue(1)]
        public double MinCache { get; set; }
        [DefaultValue(3)]
        public double MaxCache { get; set; }
        [DefaultValue("speaker")]
        public string SoundMode { get; set; }
        [DefaultValue(true)]
        public bool AutoPauseIfNavigate { get; set; }
        [DefaultValue(true)]
        public bool AutoPauseIfOpenNative { get; set; }
        public object PictureInPictureMode { get; set; }
        public EventHandler bindstatechange { get; set; }
        public EventHandler bindfullscreenchange { get; set; }
        public EventHandler bindnetstatus { get; set; }
        public EventHandler bindaudiovolumenotify { get; set; }
        public EventHandler bindenterpictureinpicture { get; set; }
        public EventHandler bindleavepictureinpicture { get; set; }
    }
}

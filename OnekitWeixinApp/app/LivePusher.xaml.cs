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
    public sealed partial class LivePusher : UserControl
    {
        public LivePusher()
        {
            this.InitializeComponent();
        }
        public string Url { get; set; }
        [DefaultValue("RTC")]
        public string Mode { get; set; }
        public bool Autopush { get; set; }
        public bool Muted { get; set; }
        [DefaultValue(true)]
        public string EnableCamera { get; set; }
        [DefaultValue(true)]
        public string AutoFocus { get; set; }
        [DefaultValue("vertical")]
        public string Orientation { get; set; }
        public double Beauty { get; set; }
        public double Whiteness { get; set; }
        [DefaultValue("9:16")]
        public string Aspect { get; set; }
        [DefaultValue(200)]
        public double MinBitrate { get; set; }
        [DefaultValue(1000)]
        public double MaxBitrate { get; set; }
        [DefaultValue("high")]
        public string AaudioQuality { get; set; }
        public string WaitingImage { get; set; }
        public string WaitingImageHash { get; set; }
        public bool Zoom { get; set; }
        [DefaultValue("front")]
        public bool DevicePosition { get; set; }
        public bool BackgroundMute { get; set; }
        public bool Mirror { get; set; }
        public bool RemoteMirror { get; set; }
        [DefaultValue("auto")]
        public string LocalMirror { get; set; }
        public double AudioReverbType { get; set; }
        [DefaultValue(true)]
        public bool EnableMic { get; set; }
        public bool EnableAgc { get; set; }
        public bool EnableAns { get; set; }
        [DefaultValue("auto")]
        public string AudioVolumeType { get; set; }
        [DefaultValue(360)]
        public double VideoWidth { get; set; }
        [DefaultValue(640)]
        public double VideoHeight { get; set; }
        [DefaultValue("smooth")]
        public string BeautyStyle { get; set; }
        [DefaultValue("standard")]
        public string Filter { get; set; }
        public EventHandler bindstatechange { get; set; }
        public EventHandler bindnetstatus { get; set; }
        public EventHandler binderror { get; set; }
        public EventHandler bindbgmstart { get; set; }
        public EventHandler bindbgmprogress { get; set; }
        public EventHandler bindbgmcomplete { get; set; }
        public EventHandler bindaudiovolumenotify { get; set; }
    }
}

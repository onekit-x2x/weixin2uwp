
using cn.onekit.js;
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
    public sealed partial class Video : UserControl
    {
        public Video()
        {
            this.InitializeComponent();
        }
        public string Src { get; set; }
        public double Duration { get; set; }
        [DefaultValue(true)]
        public bool Controls { get; set; }
        public Array DanmuList { get; set; }
        public bool DanmuBtn { get; set; }
        public bool EnableDanmu { get; set; }
        public bool Autoplay { get; set; }
        public bool Loop { get; set; }
        public double InitialTime { get; set; }
        public bool PageGesture { get; set; }
        public double Direction { get; set; }
        [DefaultValue(true)]
        public bool ShowProgress { get; set; }
        [DefaultValue(true)]
        public bool ShowFullscreenBtn { get; set; }
        [DefaultValue(true)]
        public bool ShowPlayBtn { get; set; }
        [DefaultValue(true)]
        public bool ShowCenterPlayBtn { get; set; }
        [DefaultValue(true)]
        public bool EnableProgressGesture { get; set; }
        [DefaultValue("contain")]
        public string ObjectFit { get; set; }
        public string Poster { get; set; }
        public bool ShowMuteBtn { get; set; }
        public string Title { get; set; }
        [DefaultValue("bottom")]
        public string PlayBtnPosition { get; set; }
        public bool EnablePlayGesture { get; set; }
        [DefaultValue(true)]
        public bool AutoPauseIfNavigate { get; set; }
        [DefaultValue(true)]
        public bool AutoPauseIfOpenNative { get; set; }
        public bool VslideGesture { get; set; }
        [DefaultValue(true)]
        public bool VslideGestureInFullscreen { get; set; }
        public string AdUnitId { get; set; }
        public string PosterForCrawler { get; set; }
        public string ShowCastingButton { get; set; }
        public object PictureInPictureMode { get; set; }
        public bool PictureInPictureShowProgress { get; set; }
        public bool EnableAutoRotation { get; set; }
        public bool ShowScreenLockButton { get; set; }
        public System.EventHandler bindplay { get; set; }
        public System.EventHandler bindpause { get; set; }
        public System.EventHandler bindended { get; set; }
        public System.EventHandler bindtimeupdate { get; set; }
        public System.EventHandler bindfullscreenchange { get; set; }
        public System.EventHandler bindwaiting { get; set; }
        public System.EventHandler binderror { get; set; }
        public System.EventHandler bindprogress { get; set; }
        public System.EventHandler bindloadedmetadata { get; set; }
        public System.EventHandler bindcontrolstoggle { get; set; }
        public System.EventHandler bindenterpictureinpicture { get; set; }
        public System.EventHandler bindleavepictureinpicture { get; set; }
        public System.EventHandler bindseekcomplete { get; set; }
    }
}

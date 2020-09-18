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
    public sealed partial class Audio : UserControl
    {
        public Audio()
        {
            this.InitializeComponent();
        }
        public string Src { set; get; }
        public bool Loop { set; get; }
        public bool Controls { set; get; }
        public string Poster { set; get; }
       new public string Name { set; get; }
        public string Author { set; get; }
        public EventHandler binderror { set; get; }
        public EventHandler bindplay { set; get; }
        public EventHandler bindpause { set; get; }
        public EventHandler bindtimeupdate { set; get; }
        public EventHandler bindended { set; get; }
    }
}

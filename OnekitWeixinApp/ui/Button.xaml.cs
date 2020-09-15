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
    public sealed partial class Button : UserControl
    {
        public Button()
        {
            this.InitializeComponent();
        }
        [DefaultValue("default")]
        public string Size { get; set; }
        [DefaultValue("default")]
        public string Type { get; set; }
        public bool Plain { get; set; }
        public bool Disabled { get; set; }
        new  public bool Loading { get; set; }
        public string FormType { get; set; }
        public string OpenType { get; set; }
        [DefaultValue("button-hover")]
        public string HoverClass { get; set; }
        public bool HoverDtopPropagation { get; set; }
        [DefaultValue(20)]
        public double HoverStartTime { get; set; }
        [DefaultValue(70)]
        public double HoverStayTime { get; set; }
        [DefaultValue("en")]
        public string Lang { get; set; }
        public string SessionFrom { get; set; }
        public string SendMessageTitle	 { get; set; }
        public string SendMessagePath { get; set; }
        public string SendMessageImg { get; set; }
        public string AppParameter { get; set; }
        public bool ShowMessageCard { get; set; }
        public EventHandler bindgetuserinfo { get; set; }
        public EventHandler bindcontact { get; set; }
        public EventHandler bindgetphonenumber { get; set; }
        public EventHandler binderror { get; set; }
        public EventHandler bindopensetting { get; set; }
        public EventHandler bindlaunchapp { get; set; }
    }
}

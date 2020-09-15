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
    public sealed partial class Input : UserControl
    {
        public Input()
        {
            this.InitializeComponent();
        }
        public string Value { get; set; }
        [DefaultValue("text")]
        public string Type { get; set; }
        public bool Password { get; set; }
        public string Placeholder { get; set; }
        public string PlaceholderStyle { get; set; }
        [DefaultValue("input-placeholder")]
        public string PlaceholderClass { get; set; }
        public bool Disabled { get; set; }
        [DefaultValue(140)]
        public double Maxlength { get; set; }
        public double CursorSpacing { get; set; }
        public bool AutoFocus { get; set; }
        new public bool Focus { get; set; }
        public bool ConfirmType { get; set; }
        public bool AlwaysRmbed { get; set; }
        public double Cursor { get; set; }
        [DefaultValue(-1)]
        public double SelectionStart { get; set; }
        [DefaultValue(-1)]
        public double SelectionEnd { get; set; }
        [DefaultValue(true)]
        public bool AdjustPosition { get; set; }
        public bool HoldKeyboard { get; set; }
       public EventHandler bindinput { get; set; }
        public EventHandler bindfocus { get; set; }
        public EventHandler bindblur { get; set; }
        public EventHandler bindconfirm { get; set; }
        public EventHandler bindkeyboardheightchange { get; set; }
    }
}

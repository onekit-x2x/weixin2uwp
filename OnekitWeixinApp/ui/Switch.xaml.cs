﻿using System;
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
    public sealed partial class Switch : UserControl
    {
        public Switch()
        {
            this.InitializeComponent();
        }
        public bool Checked { get; set; }
        public bool Disabled { get; set; }
        [DefaultValue("switch")]
        public string type { get; set; }
        [DefaultValue("#04BE02")]
        public string Color { get; set; }
        public EventHandler bindchange { get; set; }
    }
}

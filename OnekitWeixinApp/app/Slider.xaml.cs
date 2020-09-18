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
    public sealed partial class Slider : UserControl
    {
        public Slider()
        {
            this.InitializeComponent();
        }
        public double Min { get; set; }
        [DefaultValue(100)]
        public double Max { get; set; }
        [DefaultValue(1)]
        public double Step { get; set; }
        public bool Disabled { get; set; }
        public double Value { get; set; }
        [DefaultValue("#e9e9e9")]
        public string Color { get; set; }
        [DefaultValue("#1aad19")]
        public string SelectedColor { get; set; }
        [DefaultValue("#1aad19")]
        public string ActiveColor { get; set; }
        [DefaultValue("#e9e9e9")]
        public string BackgroundColor { get; set; }
        [DefaultValue(28)]
        public double BlockSize { get; set; }
        [DefaultValue("#ffffff")]
        public string BlockColor { get; set; }
        public double ShowValue { get; set; }
        public EventHandler bindchange { get; set; }
        public EventHandler bindchanging { get; set; }
    }
}

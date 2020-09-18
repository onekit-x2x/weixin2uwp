
using cn.onekit.js;
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
    public sealed partial class Map : UserControl
    {
        public Map()
        {
            this.InitializeComponent();
        }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [DefaultValue(16)]
        public new double Scale { get; set; }
        [DefaultValue(3)]
        public double MinScale { get; set; }
        [DefaultValue(20)]
        public double MaxScale { get; set; }
        [DefaultValue(20)]
        public cn.onekit.js.Array Markers { get; set; }
        public cn.onekit.js.Array Covers { get; set; }
        public cn.onekit.js.Array Polyline { get; set; }
        public cn.onekit.js.Array Circles { get; set; }
        public cn.onekit.js.Array Controls { get; set; }
        public cn.onekit.js.Array IncludePoints { get; set; }
        public bool ShowLocation { get; set; }
        public cn.onekit.js.Array Polygons { get; set; }
        public string Subkey { get; set; }
        [DefaultValue(1)]
        public double LayerStyle { get; set; }
        public double Rotate { get; set; }
        public double Skew { get; set; }
        public bool Enable3D { get; set; }
        public bool ShowCompass { get; set; }
        public bool ShowScale { get; set; }
        public bool EnableOverlooking { get; set; }
        [DefaultValue(true)]
        public bool EnableZoom { get; set; }
        [DefaultValue(true)]
        public bool EnableScroll { get; set; }
        public bool EnableRotate { get; set; }
        public bool EnableSatellite { get; set; }
        public bool EnableTraffic { get; set; }
        public object setting { get; set; }
        public EventHandler bindtap { get; set; }
        public EventHandler bindmarkertap { get; set; }
        public EventHandler bindlabeltap { get; set; }
        public EventHandler bindcontroltap { get; set; }
        public EventHandler bindcallouttap { get; set; }
        public EventHandler bindupdated { get; set; }
        public EventHandler bindregionchange { get; set; }
        public EventHandler bindpoitap { get; set; }
        public EventHandler bindanchorpointtap { get; set; }
    }
}

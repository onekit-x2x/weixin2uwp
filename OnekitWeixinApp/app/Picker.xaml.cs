

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
    public sealed partial class Picker : UserControl
    {
        public Picker()
        {
            this.InitializeComponent();
        }
        public string HeaderText { get; set; }
        [DefaultValue("selector")]
        public string Mode { get; set; }
        public bool disabled { get; set; }
        public System.EventHandler bindcancel { get; set; }
        public System.EventHandler bindchange { get; set; }
        public object Value { get; set; }
        //
        public IEnumerable<object> Range { get; set; }
        public string RangeKey { get; set; }
        //
        public System.EventHandler bindcolumnchange { get; set; }
        //
        public string Start { get; set; }
        public string End { get; set; }
        [DefaultValue("day")]
        public string Fields { get; set; }
        public string CustomItem { get; set; }
    }
}




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
    public sealed partial class PickerView : UserControl
    {
        public PickerView()
        {
            this.InitializeComponent();
        }
        public IEnumerable<object> Value { get; set; }
        public string IndicatorStyle { get; set; }
        public string IndicatorClass { get; set; }
        public string MaskStyle { get; set; }
        public string MaskClass { get; set; }

        public System.EventHandler bindchange { get; set; }
        public System.EventHandler bindpickstart { get; set; }
        public System.EventHandler bindpickend { get; set; }
    }
}

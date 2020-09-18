
using System.ComponentModel;
using Windows.UI.Xaml.Controls;

namespace cn.onekit.weixin.ui
{
    public sealed partial class View : UserControl
    {
        public View()
        {
            this.InitializeComponent();
        }

        public bool HoverClass { get; set; }
        [DefaultValue(false)]
        public bool HoverStopPropagation { get; set; }
        [DefaultValue(50)]
        public double HoverStartTime { get; set; }
        [DefaultValue(400)]
        public double HoverStayTime { get; set; }
    }
}


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

        public bool hoverClass { get; set; }
        [DefaultValue(false)]
        public bool hoverStopPropagation { get; set; }
        [DefaultValue(50)]
        public int hoverStartTime { get; set; }
        [DefaultValue(400)]
        public int hoverStayTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace java
{
    public static class ViewGroup_
    {
        public static int getChildCount(this Panel THIS)
        {
            return THIS.Children.Count;
        }
        public static FrameworkElement getChildAt(this Panel THIS,int index)
        {
            return (FrameworkElement)THIS.Children[index];
        }
    }
}

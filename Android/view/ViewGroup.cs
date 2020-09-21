using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace java.view
{
    public  class ViewGroup
    {
        public  int getChildCount()
        {
            return THIS.Children.Count;
        }
        public  FrameworkElement getChildAt(int index)
        {
            return (FrameworkElement)THIS.Children[index];
        }
    }
}

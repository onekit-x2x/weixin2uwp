using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace cn.onekit.weixin.ui
{
    public sealed partial class CoverImage : UserControl
    {
        public CoverImage()
        {
            this.InitializeComponent();
        }
        string _Src;
        public string Src
        {
            get { return _Src; }
            set
            {
               _Src = value;
                imgImage.Source = new BitmapImage(new Uri(_Src));
            }
        }
        public event EventHandler bindload;
        public event EventHandler binderror;

        private void imgImage_ImageOpened(object sender, RoutedEventArgs e)
        {
            if (bindload != null)
            {
                bindload.Invoke(this, new EventArgs());
            }
        }

        private void imgImage_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            if (binderror != null)
            {
                binderror.Invoke(this, new EventArgs());
            }
        }
    }
}

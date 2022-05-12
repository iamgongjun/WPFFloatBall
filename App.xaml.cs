using GalaSoft.MvvmLight.Threading;
using System;
using System.Windows;
using WPFFloatBall.View;

namespace WPFFloatBall
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherHelper.Initialize();
        }

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            try
            {
                FloatAlarmWIndow floatAlarmWIndow = new FloatAlarmWIndow();
                floatAlarmWIndow.Show();
            }
            catch (Exception ex) {  }
        }
    }
}

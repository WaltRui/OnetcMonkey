using OnetcMonkeyComputer.Forms.AutoFeed.Libs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static OnetcMonkeyComputer.Forms.AutoFeed.Libs.Win32ApiTools;

namespace OnetcMonkeyComputer.Forms.AutoFeed
{
    public class AutoFeedHelper
    {
        private static Point button_trade = new Point(570, 243);
        private static Point text_wallet = new Point(570, 243);
        private static Point text_jine = new Point(570, 290);
        private static Point button_ok = new Point(400, 400);
                
        private static Point text_pwd = new Point(300, 270);
        private static Point button_ok_pwd = new Point(200, 340);

        public static void FeedOneTime(string wallet,double jine,string password)
        {

            IntPtr handle = Win32ApiTools.GetWindowHandle("链克口袋");

            if ((int)handle <= 0)
                throw new Exception("未找到钱包界面，请确认已打开钱包！");

            //点击“发起转账按钮”
            Win32ApiTools.MouseLeftClick(handle, button_trade);

            //保险起见，等待1秒
            Thread.Sleep(1000);
            //点击钱包地址输入框
            Win32ApiTools.MouseLeftClick(handle, text_wallet);
            //等待1秒
            Thread.Sleep(500);
            //输入钱包地址
            Win32ApiTools.KeyPress(handle, wallet);
            Thread.Sleep(500);
            Win32ApiTools.MouseLeftClick(handle, text_jine);
            Win32ApiTools.KeyPress(handle, jine.ToString());
            Thread.Sleep(500);
            Win32ApiTools.MouseLeftClick(handle, button_ok);

            Thread.Sleep(500);

            IntPtr password_handle = FindPasswordWindow();
            Thread.Sleep(3000);

            Win32ApiTools.MouseLeftClick(password_handle, text_pwd);
            Win32ApiTools.KeyPress(password_handle, password);
            Thread.Sleep(500);
            Win32ApiTools.MouseLeftClick(password_handle, button_ok_pwd);

            Thread.Sleep(3000);
            var aa = ConfirmSuccess();
            if (!aa)
                throw new Exception("校验是否成功失败，请检查密码是否正确！");            
        }

        private static IntPtr FindPasswordWindow()
        {
            IntPtr password_handle = (IntPtr)0;
            int i = 0;
            while (true)
            {
                password_handle = Win32ApiTools.GetWindowHandle("", "Chrome_WidgetWin_1");

                RECT rc = Win32ApiTools.GetWindowRect(password_handle);
                int width = rc.Right - rc.Left;                        //窗口的宽度
                int height = rc.Bottom - rc.Top;                   //窗口的高度
                int x = rc.Left;
                int y = rc.Top;
                if (width > 100 && height > 80)
                    break;
                else
                    password_handle = (IntPtr)0;
                i++;
                if (i > 30)
                    throw new Exception("出现异常，已退出自动转账！");
                Thread.Sleep(500);

            }

            return password_handle;
        }

        private static bool ConfirmSuccess()
        {
            IntPtr password_handle = (IntPtr)0;
            int i = 0;
            while (true)
            {
                password_handle = Win32ApiTools.GetWindowHandle("", "Chrome_WidgetWin_1");

                RECT rc = Win32ApiTools.GetWindowRect(password_handle);
                int width = rc.Right - rc.Left;                        //窗口的宽度
                int height = rc.Bottom - rc.Top;                   //窗口的高度
                int x = rc.Left;
                int y = rc.Top;
                if (width <= 100 && height <= 80)
                    return true;
                else
                {
                    Thread.Sleep(500);
                    i++;
                }
                if (i > 20)
                    return false;
            }
        }
    }
}

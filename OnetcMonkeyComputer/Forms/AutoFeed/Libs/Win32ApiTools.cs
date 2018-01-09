using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.AutoFeed.Libs
{
    public class Win32ApiTools
    {
        /// <summary>
        /// 根据标题获取窗口句柄
        /// </summary>
        /// <param name="className"></param>
        /// <param name="windowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string className, string windowName);


        [DllImport("User32.dll", EntryPoint = "GetWindowText")]//根据标题获取窗口句柄
        public extern static int GetWindowText(int hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]//指定坐标处窗体句柄
        public static extern int WindowFromPoint(int xPoint, int yPoint);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd1">在其中查找子的父窗口。如设为零，表示使用桌面窗口（通常说的顶级窗口都被认为是桌面的子窗口，所以也会对它们进行查找）</param>
        /// <param name="hWnd2">从这个窗口后开始查找。这样便可利用对FindWindowEx的多次调用找到符合条件的所有子窗口。如设为零，表示从第一个子窗口开始搜索</param>
        /// <param name="lpsz1">欲搜索的类名。零表示忽略</param>
        /// <param name="lpsz2">欲搜索的类名。零表示忽略</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]//根据父窗体查找子窗体
        public static extern IntPtr FindWindowEx(IntPtr hWnd1,int hWnd2,string lpsz1,string lpsz2);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        
        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        public static extern int PostMessage(IntPtr hWnd, int Msg, Keys wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        public static extern int PostMessage(IntPtr hWnd, int Msg, Keys wParam, uint lParam);


        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        [DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;                             //最左坐标
            public int Top;                             //最上坐标
            public int Right;                           //最右坐标
            public int Bottom;                        //最下坐标
        }

        const uint downCode = 0x201; // Left click down code 
        const uint upCode = 0x202; // Left click up code 

        const int WM_KEYDOWN = 0X100;//按键按下时
        const int WM_KEYUP = 0X101;//按键放开时
        const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        const int VK_LCONTROL = 0xA2; //Left Control key code
        const int VK_MENU = 0x12; //Alt key code
        const int VK_UP = 0x26; //Up cursor key code

        public const uint WM_SETTEXT = 0x000C;

        public static IntPtr GetWindowHandle(string title,string className=null)
        {
            IntPtr handle = FindWindow(className, title);

            return handle;
        }

        public static IntPtr FindWindowByParent(IntPtr parent ,string title)
        {
            IntPtr handle = FindWindowEx(parent,0, title, "0");

            return handle;
        }

        public static RECT GetWindowRect(IntPtr handle)
        {
            RECT rc = new RECT();
            GetWindowRect(handle, ref rc);
            return rc;
        }


        public static void MouseLeftClick(IntPtr handle,Point point)
        {
            IntPtr lParam = (IntPtr)((point.Y << 16) | point.X); // The coordinates 
            IntPtr wParam = IntPtr.Zero; // Additional parameters for the click (e.g. Ctrl) 
          
            SendMessage(handle, downCode, wParam, lParam); // Mouse button down 
            SendMessage(handle, upCode, wParam, lParam); // Mouse button up 
             
        }

        public static void KeyPress(IntPtr handle,string str,bool CaseSensitivity=false)
        {
            bool isteshuzif = false;
            foreach (char c in str)
            {
                if ((!char.IsLetter(c)) && (!char.IsNumber(c)) && c!='.')  //既不是字母又不是数字的就认为是特殊字符
                    isteshuzif = true;
            }

            if (!isteshuzif)
            {
                foreach (var c in str)
                {
                    bool islock = false;

                    Keys k1 = ConverKeys(c, out islock);
                    SetCaplock(islock);
                    PostMessage(handle, 256, k1, 1);
                }
            }else
            {
                Clipboard.SetDataObject(str, true);
                Thread.Sleep(500);
                keybd_event((byte)Keys.ControlKey, 0, 0, 0);
                keybd_event((byte)Keys.V, 0, 0, 0);
                keybd_event((byte)Keys.V, 0, KEYEVENTF_KEYUP, 0);
                keybd_event((byte)Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
                Thread.Sleep(500);
                Clipboard.SetDataObject("", true);
            }
           
        }

        private static void SetCaplock(bool isLock)
        {


        }
        private static Keys ConverKeys(char c,out bool iscaplock)
        {
            Keys key;
            if(c>='A' && c<='Z')
            {
                iscaplock = true;

                return (Keys)c;
            }
            else if(c>='a' && c<= 'z')
            {
                iscaplock = false;

                return (Keys)(c-32);
            }
            else if (c >= '0' && c <= '9')
            {
                iscaplock = false;

                return (Keys)c;
            }

            switch (c)
            {
                case '*':
                    key = (Keys)(106);
                    break;
                case '+':
                    key = (Keys)(107);
                    break;
                case '-':
                    key = (Keys)(109);
                    break;
                case '.':
                    key = Keys.Decimal;
                    break;

                default:
                    throw new Exception("仅支持数字、字母、+、-、*、.");
                    
            }
            iscaplock = false;
            return key;
        }
    }
}

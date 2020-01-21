using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
namespace 카톡광고꺼져
{
	class Program
	{
		[DllImport("user32.dll")]
		public static extern int FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindowEx(int hWnd1, int hWnd2, string lpsz1, string lpsz2);

		[DllImport("user32")]
		public static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);

		[DllImport("user32")]
		public static extern int SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
		  
	 	[DllImport("user32.dll")]
       	 	static extern bool GetWindowRect(int hWnd, out RECT lpRect);

		public static void Main(string[] args)
		{
			int katalk = FindWindow(null, "카카오톡");
			IntPtr ADS = FindWindowEx(katalk, 0, "EVA_Window", null);
			ShowWindow(ADS, 0);
			RECT rect;
 			GetWindowRect(katalk, out rect);
			int x = (rect.Right - rect.Left);
			int y = (rect.Bottom - rect.Top);
			IntPtr katalk2 = FindWindowEx(katalk, 0, "EVA_ChildWindow", null);
			SetWindowPos(katalk2, 0, 0, 0, x, y, 0);
		}
		
		public struct RECT
        	{
            		public int Left;       
            		public int Top;         
            		public int Right;      
            		public int Bottom;
        	}
	}
}

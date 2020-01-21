/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2020-01-21
 * Time: 오전 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
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
		public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
		                  
		[DllImport("user32")]
		public static extern int GetWindowRect(int hwnd, ref RECT lpRect);
			
		public static void Main(string[] args)
		{
			ShowWindow(FindWindowEx(FindWindow(null, "카카오톡"), 0, "EVA_Window", null), 0);
		}
	}
}
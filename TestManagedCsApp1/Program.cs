using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class MainClass {


    [DllImport("dllLog.dll", EntryPoint = "multiply")]
    static extern int multiply(int x, int y);

    [DllImport("dllLog.dll", EntryPoint = "multiplyUsePointer")]
    static extern void _multiplyUsePointer(ref int x, ref int y, out int result);


    [DllImport("dllLog.dll", EntryPoint = "setNameString", CharSet = CharSet.Ansi)]
    static extern void _setNameString(string t);

    [DllImport("dllLog.dll", EntryPoint = "getNameString", CharSet = CharSet.Ansi)]
    static extern IntPtr _getNameString();

    [DllImport("dllLog.dll", EntryPoint = "setNameWString", CharSet = CharSet.Unicode)]
    static extern void _setNameWString(string t);

    [DllImport("dllLog.dll", EntryPoint = "getNameWString", CharSet = CharSet.Unicode)]
    static extern IntPtr _getNameWString();


    [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBox")]
    public static extern int MyNewMessageBoxMethod(IntPtr hWnd, String text, String caption, uint type);



    public static void Main() {

        int x = 9;
        int y = 10;

        int z = multiply(x, y);
        Console.WriteLine(z);

        int x2 = 1
            , y2 = 2, z2 = 0;
        _multiplyUsePointer(ref x2, ref y2, out z2);
        Console.WriteLine(z2);

        string testString = "TEST aaa あああ";
        _setNameString(testString);
        Console.WriteLine("getNameString = " + Marshal.PtrToStringAnsi(_getNameString()));

        _setNameWString(testString);
        Console.WriteLine("getNameWString = " + Marshal.PtrToStringUni(_getNameWString()));

        //MyNewMessageBoxMethod(new IntPtr(0), "Hello World!", "Hello Dialog", 0);
    }
}


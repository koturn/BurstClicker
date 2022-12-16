using System.Runtime.InteropServices;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Used by <see cref="InputUtil.NativeMethods.SendInput(int, ref Input, int)"/> or <see cref="InputUtil.NativeMethods.SendInput(int, Input[], int)"/>
    /// to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.
    /// </summary>
    /// <remarks><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-input"/></remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct Input
    {
        /// <summary>
        /// The type of the input event.
        /// </summary>
        public InputType Type;
        /// <summary>
        /// The information about a simulated mouse, keyboard or hardware event.
        /// </summary>
        public InputUnion Ui;
    }
}

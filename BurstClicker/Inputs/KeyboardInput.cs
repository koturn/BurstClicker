using System;
using System.Runtime.InteropServices;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Contains information about a simulated keyboard event.
    /// </summary>
    /// <remarks><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput"/></remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        /// <summary>
        /// A virtual-key code.
        /// The code must be a value in the range 1 to 254.
        /// If the <see cref="Flags"/> member specifies <see cref="KeyEventF.Unicode"/>, <see cref="VirtualKey"/> must be 0.
        /// </summary>
        public short VirtualKey;
        /// <summary>
        /// A hardware scan code for the key.
        /// If <see cref="Flags"/> specifies <see cref="KeyEventF.Unicode"/>,
        /// <see cref="ScanCode"/> specifies a Unicode character which is to be sent to the foreground application.
        /// </summary>
        public short ScanCode;
        /// <summary>
        /// Specifies various aspects of a keystroke.
        /// This member can be certain combinations of the <see cref="KeyEventF"/> values.
        /// </summary>
        public KeyEventF Flags;
        /// <summary>
        /// The time stamp for the event, in milliseconds.
        /// If this parameter is zero, the system will provide its own time stamp.
        /// </summary>
        public int Time;
        /// <summary>
        /// An additional value associated with the keystroke.
        /// Use the GetMessageExtraInfo function to obtain this information.
        /// </summary>
        public IntPtr ExtraInfo;
    }
}

using System;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Flag values of <see cref="KeyboardInput.Flags"/>.
    /// </summary>
    /// <remarks>
    /// <para><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput"/></para>
    /// <para><see cref="KeyboardInput"/> supports nonkeyboard-input methods—such as handwriting recognition or voice recognition
    /// —as if it were text input by using the <see cref="Unicode"/> flag.
    /// If <see cref="Unicode"/> is specified, <see cref="InputUtil.NativeMethods.SendInput(int, ref Input, int)"/> or <see cref="InputUtil.NativeMethods.SendInput(int, Input[], int)"/>
    /// sends a WM_KEYDOWN or WM_KEYUP message to the foreground thread's message queue with wParam equal to VK_PACKET.
    /// Once GetMessage or PeekMessage obtains this message, passing the message to TranslateMessage posts a WM_CHAR message with the Unicode character originally specified by wScan.
    /// This Unicode character will automatically be converted to the appropriate ANSI value if it is posted to an ANSI window.</para>
    /// <para>Set the <see cref="ScanCode"/> flag to define keyboard input in terms of the scan code.
    /// This is useful to simulate a physical keystroke regardless of which keyboard is currently being used.
    /// The virtual key value of a key may alter depending on the current keyboard layout or what other keys were pressed, but the scan code will always be the same.</para>
    /// </remarks>
    [Flags]
    public enum KeyEventF : int
    {
        /// <summary>
        /// If specified, the scan code was preceded by a prefix byte that has the value 0xE0 (224).
        /// </summary>
        ExtendedKey = 0x00000001,
        /// <summary>
        /// If specified, the key is being released. If not specified, the key is being pressed.
        /// </summary>
        KeyUp = 0x00000002,
        /// <summary>
        /// If specified, wScan identifies the key and <see cref="KeyboardInput.VirtualKey"/> is ignored.
        /// </summary>
        Unicode = 0x00000004,
        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke.
        /// The wVk parameter must be zero.
        /// This flag can only be combined with the <see cref="KeyUp"/> flag.
        /// For more information, see the Remarks section.
        /// </summary>
        ScanCode = 0x00000008
    }
}

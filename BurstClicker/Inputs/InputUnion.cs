using System.Runtime.InteropServices;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Union structure of <see cref="MouseInput"/>, <see cref="KeyboardInput"/> or <see cref="HardwareInput"/>.
    /// </summary>
    /// <remarks>
    /// <para><seealso cref="Input"/></para>
    /// <para><see cref="KeyboardInput"/> supports nonkeyboard input methods, such as handwriting recognition or voice recognition, as if it were text input by using the <see cref="KeyEventF.Unicode"/> flag.
    /// For more information, see the remarks section of <see cref="KeyboardInput"/>.</para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        /// <summary>
        /// The information about a simulated mouse event.
        /// </summary>
        [FieldOffset(0)]
        public MouseInput Mouse;
        /// <summary>
        /// The information about a simulated keyboard event.
        /// </summary>
        [FieldOffset(0)]
        public KeyboardInput Keyboard;
        /// <summary>
        /// The information about a simulated hardware event.
        /// </summary>
        [FieldOffset(0)]
        public HardwareInput Hardware;
    }
}

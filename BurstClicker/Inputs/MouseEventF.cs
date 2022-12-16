using System;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Flag values of <see cref="MouseInput.Flags"/>.
    /// </summary>
    /// <remarks>
    /// <para><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput"/></para>
    /// <para>If the mouse has moved, indicated by <see cref="Move"/>, dx and dy specify information about that movement.
    /// The information is specified as absolute or relative integer values.</para>
    /// <para>If <see cref="Absolute"/> value is specified, <see cref="MouseInput.X"/> and <see cref="MouseInput.Y"/> contain normalized absolute coordinates between 0 and 65,535.
    /// The event procedure maps these coordinates onto the display surface.
    /// Coordinate (0,0) maps onto the upper-left corner of the display surface; coordinate (65535, 65535) maps onto the lower-right corner.
    /// In a multimonitor system, the coordinates map to the primary monitor.</para>
    /// <para>If <see cref="VirtualDesk"/> is specified, the coordinates map to the entire virtual desktop.</para>
    /// <para>If the <see cref="Absolute"/> value is not specified, <see cref="MouseInput.X"/> and <see cref="MouseInput.Y"/> specify movement relative to the previous mouse event (the last reported position).
    /// Positive values mean the mouse moved right (or down); negative values mean the mouse moved left (or up).</para>
    /// <para>Relative mouse motion is subject to the effects of the mouse speed and the two-mouse threshold values.
    /// A user sets these three values with the Pointer Speed slider of the Control Panel's Mouse Properties sheet.
    /// You can obtain and set these values using the SystemParametersInfo function.</para>
    /// <para>The system applies two tests to the specified relative mouse movement.
    /// If the specified distance along either the x or y axis is greater than the first mouse threshold value, and the mouse speed is not zero, the system doubles the distance.
    /// If the specified distance along either the x or y axis is greater than the second mouse threshold value, and the mouse speed is equal to two, the system doubles the distance that resulted from applying the first threshold test.
    /// It is thus possible for the system to multiply specified relative mouse movement along the x or y axis by up to four times.</para>
    /// </remarks>
    [Flags]
    public enum MouseEventF : int
    {
        /// <summary>
        /// Movement occurred.
        /// </summary>
        Move = 0x00000001,
        /// <summary>
        /// The left button was pressed.
        /// </summary>
        LeftDown = 0x00000002,
        /// <summary>
        /// The left button was released.
        /// </summary>
        LeftUp = 0x00000004,
        /// <summary>
        /// The right button was pressed.
        /// </summary>
        RightDown = 0x00000008,
        /// <summary>
        /// The right button was released.
        /// </summary>
        RightUp = 0x00000010,
        /// <summary>
        /// The middle button was pressed.
        /// </summary>
        MiddleDown = 0x00000020,
        /// <summary>
        /// The middle button was released.
        /// </summary>
        MiddleUp = 0x00000040,
        /// <summary>
        /// An X button was pressed.
        /// </summary>
        XDown = 0x00000080,
        /// <summary>
        /// An X button was released.
        /// </summary>
        XUp = 0x00000100,
        /// <summary>
        /// The wheel was moved, if the mouse has a wheel.
        /// The amount of movement is specified in <see cref="MouseInput.Data"/>.
        /// </summary>
        Wheel = 0x00000800,
        /// <summary>
        /// <para>The wheel was moved horizontally, if the mouse has a wheel.
        /// The amount of movement is specified in <see cref="MouseInput.Data"/>.</para>
        /// <para>Windows XP/2000: This value is not supported.</para>
        /// </summary>
        HWheel = 0x00001000,
        /// <summary>
        /// <para>The WM_MOUSEMOVE messages will not be coalesced.
        /// The default behavior is to coalesce WM_MOUSEMOVE messages.</para>
        /// <para>Windows XP/2000: This value is not supported.</para>
        /// </summary>
        MoveNoCoalesce = 0x00002000,
        /// <summary>
        /// Maps coordinates to the entire desktop. Must be used with <see cref="Absolute"/>.
        /// </summary>
        VirtualDesk = 0x00004000,
        /// <summary>
        /// The <see cref="MouseInput.X"/> and <see cref="MouseInput.Y"/> members contain normalized absolute coordinates.
        /// If the flag is not set, <see cref="MouseInput.X"/> and <see cref="MouseInput.Y"/> contain relative data (the change in position since the last reported position).
        /// This flag can be set, or not set, regardless of what kind of mouse or other pointing device, if any, is connected to the system.
        /// For further information about relative mouse motion, see the Remarks section.
        /// </summary>
        Absolute = 0x00008000
    }
}

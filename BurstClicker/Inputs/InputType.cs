namespace BurstClicker.Inputs
{
    /// <summary>
    /// The type of the input event.
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// The event is a mouse event. Use the <see cref="InputUnion.Mouse"/> structure of the union.
        /// </summary>
        Mouse = 0,
        /// <summary>
        /// The event is a keyboard event. Use the <see cref="InputUnion.Keyboard"/> structure of the union.
        /// </summary>
        Keyboard = 1,
        /// <summary>
        /// The event is a hardware event. Use the <see cref="InputUnion.Hardware"/> structure of the union.
        /// </summary>
        Hardware = 2,
    }
}

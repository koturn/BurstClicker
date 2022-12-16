using System.Runtime.InteropServices;


namespace BurstClicker.Inputs
{
    /// <summary>
    /// Utility class of SendInput().
    /// </summary>
    public static class InputUtil
    {
        /// <summary>
        /// Size of <see cref="Input"/>.
        /// </summary>
        private static readonly int SizeOfInput;


        /// <summary>
        /// Initialize static members.
        /// </summary>
        static InputUtil()
        {
            SizeOfInput = Marshal.SizeOf(typeof(Input));
        }


        /// <summary>
        /// Managed wrapper of <see cref="NativeMethods.SendInput(int, ref Input, int)"/>.
        /// </summary>
        /// <param name="input">An reference of <see cref="Input"/> structures.
        /// This structure represents an event to be inserted into the keyboard or mouse input stream.</param>
        /// <returns>The number of events that it successfully inserted into the keyboard or mouse input stream.</returns>
        public static int SendInput(ref Input input)
        {
            return NativeMethods.SendInput(1, ref input, SizeOfInput);
        }

        /// <summary>
        /// Managed wrapper of <see cref="NativeMethods.SendInput(int, Input[], int)"/>.
        /// </summary>
        /// <param name="inputs">An array of <see cref="Input"/> structures.
        /// Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
        /// <returns>The number of events that it successfully inserted into the keyboard or mouse input stream.</returns>
        public static int SendInput(Input[] inputs)
        {
            return NativeMethods.SendInput(inputs.Length, inputs, SizeOfInput);
        }

        /// <summary>
        /// Provides native methods.
        /// </summary>
        internal class NativeMethods
        {
            /// <summary>
            /// Synthesizes keystrokes, mouse motions, and button clicks.
            /// </summary>
            /// <param name="nInputs">The number of structures in the <paramref name="input"/>. Muse be 1.</param>
            /// <param name="input">An reference of <see cref="Input"/> structures.
            /// This structure represents an event to be inserted into the keyboard or mouse input stream.</param>
            /// <param name="cbSize">The size, in bytes, of an <see cref="Input"/> structure.
            /// If cbSize is not the size of an <see cref="Input"/> structure, the function fails.</param>
            /// <returns>
            /// <para>The function returns the number of events that it successfully inserted into the keyboard or mouse input stream.
            /// If the function returns zero, the input was already blocked by another thread.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// <para>This function fails when it is blocked by UIPI.
            /// Note that neither <see cref="Marshal.GetLastWin32Error"/> nor the return value will indicate the failure was caused by UIPI blocking.</para>
            /// </returns>
            /// <remarks><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput"/></remarks>
            [DllImport("user32.dll", SetLastError = true)]
            public extern static int SendInput(int nInputs, ref Input input, int cbSize);

            /// <summary>
            /// Synthesizes keystrokes, mouse motions, and button clicks.
            /// </summary>
            /// <param name="nInputs">The number of structures in the <paramref name="inputs"/>. Muse be 1.</param>
            /// <param name="inputs">An array of <see cref="Input"/> structures.
            /// Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
            /// <param name="cbSize">The size, in bytes, of an <see cref="Input"/> structure.
            /// If cbSize is not the size of an <see cref="Input"/> structure, the function fails.</param>
            /// <returns>
            /// <para>The function returns the number of events that it successfully inserted into the keyboard or mouse input stream.
            /// If the function returns zero, the input was already blocked by another thread.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// <para>This function fails when it is blocked by UIPI.
            /// Note that neither <see cref="Marshal.GetLastWin32Error"/> nor the return value will indicate the failure was caused by UIPI blocking.</para>
            /// </returns>
            /// <remarks><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput"/></remarks>
            [DllImport("user32.dll", SetLastError = true)]
            public extern static int SendInput(int nInputs, Input[] inputs, int cbSize);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurstClicker.Inputs;


namespace BurstClicker
{
    /// <summary>
    /// User code of <see cref="BurstClickForm"/>.
    /// </summary>
    public partial class BurstClickForm : Form
    {
        /// <summary>
        /// WIndows message ID about Hot Keys.
        /// </summary>
        private const int WM_HOTKEY = 0x0312;

        /// <summary>
        /// ID of <see cref="NativeMethods.RegisterHotKey(IntPtr, int, ModifierKey, Keys)"/>.
        /// </summary>
        private int _id = -1;
        /// <summary>
        /// Click burst task.
        /// </summary>
        private Task? _task;
        /// <summary>
        /// <see cref="CancellationTokenSource"/> for <see cref="_task"/>.
        /// </summary>
        private CancellationTokenSource? _cts;

        /// <summary>
        /// Initialize components.
        /// </summary>
        public BurstClickForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Windows message reciever to start/stop <see cref="_task"/>.
        /// </summary>
        /// <param name="m">Windows message.</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                if ((int)m.WParam == _id)
                {
                    ToggleTask();
                }
            }
        }

        /// <summary>
        /// Start/Stop <see cref="_task"/>.
        /// </summary>
        private void ToggleTask()
        {
            if (_task != null)
            {
                if (_cts != null)
                {
                    _cts.Cancel();
                }
                _task.Wait();
                _task = null;
                Text = "BurstClicker: Inactive";
            }
            else
            {
                _task = Task.Factory.StartNew(
                    () =>
                    {
                        var cts = _cts;
                        var inputDown = new Input()
                        {
                            Type = InputType.Mouse,
                            Ui = new InputUnion()
                            {
                                Mouse = new MouseInput()
                                {
                                    X = 0,
                                    Y = 0,
                                    Data = 0,
                                    Flags = MouseEventF.LeftDown,
                                    Time = 0,
                                    ExtraInfo = IntPtr.Zero
                                }
                            }
                        };
                        var inputUp = new Input()
                        {
                            Type = InputType.Mouse,
                            Ui = new InputUnion()
                            {
                                Mouse = new MouseInput()
                                {
                                    X = 0,
                                    Y = 0,
                                    Data = 0,
                                    Flags = MouseEventF.LeftUp,
                                    Time = 0,
                                    ExtraInfo = IntPtr.Zero
                                }
                            }
                        };

                        while (true)
                        {
                            InputUtil.SendInput(ref inputDown);
                            Thread.Sleep(16);
                            InputUtil.SendInput(ref inputUp);
                            Thread.Sleep(16);
                            if (cts != null && cts.IsCancellationRequested)
                            {
                                break;
                            }
                        }
                    },
                    (_cts = new CancellationTokenSource()).Token,
                    TaskCreationOptions.LongRunning,
                    TaskScheduler.Default);
                Text = "BurstClicker: Active";
                TopMost = true;
                TopMost = false;
            }
        }

        /// <summary>
        /// Called then this form loaded.
        /// </summary>
        /// <param name="sender">Instance of the <see cref="BurstClickForm"/>.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void BurstClickForm_Load(object sender, EventArgs e)
        {
            for (int i = 0x0000; i <= 0xbfff; i++)
            {
                if (NativeMethods.RegisterHotKey(Handle, i, ModifierKey.None, Keys.F11))
                {
                    _id = i;
                    break;
                }
            }
        }

        /// <summary>
        /// Called then before closing this form.
        /// </summary>
        /// <param name="sender">Instance of the <see cref="BurstClickForm"/>.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void BurstClickForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NativeMethods.UnregisterHotKey(Handle, _id);
        }

        /// <summary>
        /// Provides native methods.
        /// </summary>
        internal static class NativeMethods
        {
            /// <summary>
            /// Defines a system-wide hot key.
            /// </summary>
            /// <param name="hWnd">A handle to the window that will receive <see cref="WM_HOTKEY"/> messages generated by the hot key.
            /// If this parameter is NULL, WM_HOTKEY messages are posted to the message queue of the calling thread and must be processed in the message loop.</param>
            /// <param name="id">The identifier of the hot key.
            /// If the <paramref name="hWnd"/> parameter is <see cref="IntPtr.Zero"/>, then the hot key is associated with the current thread rather than with a particular window.
            /// If a hot key already exists with the same hWnd and id parameters, see Remarks for the action taken.</param>
            /// <param name="modKey">The keys that must be pressed in combination with the key specified by the uVirtKey parameter in order to generate the <see cref="WM_HOTKEY"/> message.
            /// The fsModifiers parameter can be a combination of the <see cref="ModifierKey"/> values.</param>
            /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
            /// <returns>
            /// <para>If the function succeeds, the return value is true.</para>
            /// <para>If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// </returns>
            /// <remarks>
            /// <para><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey"/></para>
            /// <para>When a key is pressed, the system looks for a match against all hot keys.
            /// Upon finding a match, the system posts the <see cref="WM_HOTKEY"/> message to the message queue of the window with which the hot key is associated.
            /// If the hot key is not associated with a window, then the WM_HOTKEY message is posted to the thread associated with the hot key.</para>
            /// <para>This function cannot associate a hot key with a window created by another thread.</para>
            /// <para><see cref="RegisterHotKey(IntPtr, int, ModifierKey, Keys)"/> fails if the keystrokes specified for the hot key have already been registered by another hot key.</para>
            /// <para>If a hot key already exists with the same <paramref name="hWnd"/> and id parameters, it is maintained along with the new hot key.
            /// The application must explicitly call <see cref="UnregisterHotKey(IntPtr, int)"/> to unregister the old hot key.</para>
            /// <para>Windows Server 2003: If a hot key already exists with the same hWnd and id parameters, it is replaced by the new hot key.</para>
            /// <para>The F12 key is reserved for use by the debugger at all times, so it should not be registered as a hot key.
            /// Even when you are not debugging an application, F12 is reserved in case a kernel-mode debugger or a just-in-time debugger is resident.</para>
            /// <para>An application must specify an id value in the range 0x0000 through 0xBFFF.
            /// A shared DLL must specify a value in the range 0xC000 through 0xFFFF (the range returned by the GlobalAddAtom function).
            /// To avoid conflicts with hot-key identifiers defined by other shared DLLs, a DLL should use the GlobalAddAtom function to obtain the hot-key identifier.</para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool RegisterHotKey(IntPtr hWnd, int id, ModifierKey modKey, Keys key);

            /// <summary>
            /// Frees a hot key previously registered by the calling thread.
            /// </summary>
            /// <param name="HWnd">A handle to the window associated with the hot key to be freed.
            /// This parameter should be <see cref="IntPtr.Zero"/> if the hot key is not associated with a window.</param>
            /// <param name="id">The identifier of the hot key to be freed.</param>
            /// <returns>
            /// <para>If the function succeeds, the return value is nonzero.</para>
            /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool UnregisterHotKey(IntPtr HWnd, int id);
        }
    }

    /// <summary>
    /// Modifier Key falgs.
    /// </summary>
    /// <remarks>
    /// <seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey"/>
    /// </remarks>
    [Flags]
    public enum ModifierKey : int
    {
        /// <summary>
        /// No modifier key.
        /// </summary>
        None = 0x0000,
        /// <summary>
        /// Either ALT key must be held down.
        /// </summary>
        Alt = 0x0001,
        /// <summary>
        /// Either CTRL key must be held down.
        /// </summary>
        Control = 0x0002,
        /// <summary>
        /// Either SHIFT key must be held down.
        /// </summary>
        Shift = 0x0004,
        /// <summary>
        /// Either WINDOWS key was held down.
        /// These keys are labeled with the Windows logo.
        /// Keyboard shortcuts that involve the WINDOWS key are reserved for use by the operating system.
        /// </summary>
        Windows = 0x0008,
        /// <summary>
        /// <para>Changes the hotkey behavior so that the keyboard auto-repeat does not yield multiple hotkey notifications.</para>
        /// <para>Windows Vista: This flag is not supported.</para>
        /// </summary>
        NoRepeat = 0x4000
    }
}
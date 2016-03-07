using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sys.Help
{
    class SystemKeys
    {
        #region F1-F12
        internal static readonly short VK_F1 = 0x70;
        internal static readonly short VK_F2 = 0x71;
        internal static readonly short VK_F3 = 0x72;
        internal static readonly short VK_F4 = 0x73;
        internal static readonly short VK_F5 = 0x74;
        internal static readonly short VK_F6 = 0x75;
        internal static readonly short VK_F7 = 0x76;
        internal static readonly short VK_F8 = 0x77;
        internal static readonly short VK_F9 = 0x78;
        internal static readonly short VK_F10 = 0x79;
        internal static readonly short VK_F11 = 0x7A;
        internal static readonly short VK_F12 = 0x7B;
        #endregion

        #region 0-9
        internal static readonly short VK_0 = 0x30;
        internal static readonly short VK_1 = 0x31;
        internal static readonly short VK_2 = 0x32;
        internal static readonly short VK_3 = 0x33;
        internal static readonly short VK_4 = 0x34;
        internal static readonly short VK_5 = 0x35;
        internal static readonly short VK_6 = 0x36;
        internal static readonly short VK_7 = 0x37;
        internal static readonly short VK_8 = 0x38;
        internal static readonly short VK_9 = 0x39;
        #endregion

        #region A-Z
        internal static readonly short VK_A = 0x41;
        internal static readonly short VK_B = 0x42;
        internal static readonly short VK_C = 0x43;
        internal static readonly short VK_D = 0x44;
        internal static readonly short VK_E = 0x45;
        internal static readonly short VK_F = 0x46;
        internal static readonly short VK_G = 0x47;
        internal static readonly short VK_H = 0x48;
        internal static readonly short VK_I = 0x49;
        internal static readonly short VK_J = 0x4A;
        internal static readonly short VK_K = 0x4B;
        internal static readonly short VK_L = 0x4C;
        internal static readonly short VK_M = 0x4D;
        internal static readonly short VK_N = 0x4E;
        internal static readonly short VK_O = 0x4F;
        internal static readonly short VK_P = 0x50;
        internal static readonly short VK_Q = 0x51;
        internal static readonly short VK_R = 0x52;
        internal static readonly short VK_S = 0x53;
        internal static readonly short VK_T = 0x54;
        internal static readonly short VK_U = 0x55;
        internal static readonly short VK_V = 0x56;
        internal static readonly short VK_W = 0x57;
        internal static readonly short VK_X = 0x58;
        internal static readonly short VK_Y = 0x59;
        internal static readonly short VK_Z = 0x5A;
        #endregion

        internal static readonly short VK_LEFT = 0x25;
        internal static readonly short VK_UP = 0x26;
        internal static readonly short VK_RIGHT = 0x27;
        internal static readonly short VK_DOWN = 0x28;
        internal static readonly short VK_NONE = 0x00;
        internal static readonly short VK_ESCAPE = 0x1B;
        internal static readonly short VK_EXECUTE = 0x2B;
        internal static readonly short VK_CANCEL = 0x03;
        /// <summary>
        /// 回车键
        /// </summary>
        internal static readonly short VK_RETURN = 0x0D;
        internal static readonly short VK_CONTROL = 0x11;
        internal static readonly short VK_ACCEPT = 0x1E;
        internal static readonly short VK_BACK = 0x08;
        internal static readonly short VK_TAB = 0x09;
        internal static readonly short VK_DELETE = 0x2E;
        internal static readonly short VK_CAPITAL = 0x14;
        internal static readonly short VK_NUMLOCK = 0x90;
        internal static readonly short VK_SPACE = 0x20;
        internal static readonly short VK_DECIMAL = 0x6E;
        internal static readonly short VK_SUBTRACT = 0x6D;
        internal static readonly short VK_ADD = 0x6B;
        internal static readonly short VK_DIVIDE = 0x6F;
        internal static readonly short VK_MULTIPLY = 0x6A;
        internal static readonly short VK_INSERT = 0x2D;
        internal static readonly short VK_OEM_1 = 0xBA;
        /// <summary>
        /// 按下键
        /// </summary>
        internal static readonly short WM_KEYDOWN = 0x100;
        /// <summary>
        /// 键弹起
        /// </summary>
        internal static readonly short WM_KEYUP = 0x101;
        /// <summary>
        /// 字符
        /// </summary>
        internal static readonly short WM_CHAR = 0x102;
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoRadioElectrico.WinForms.Utils
{
    public static class Miscellaneous
    {
        public static bool ValidateAmount(KeyPressEventArgs pKeyPress)
        {
            if (Char.IsDigit(pKeyPress.KeyChar))
            {
                return false;
            }
            else if (Char.IsControl(pKeyPress.KeyChar))
            {
                return false;
            }
            else if (Char.IsSeparator(pKeyPress.KeyChar))
            {
                return true;
            }
            else if (Char.IsPunctuation(pKeyPress.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateTelephone(KeyPressEventArgs pKeyPress)
        {
            if (pKeyPress.KeyChar == '-' )
            {
                return false;
            }
            else if (Char.IsNumber(pKeyPress.KeyChar))
            {
                return false;
            }
            else if (pKeyPress.KeyChar == '(')
            {
                return false;
            }
            else if (pKeyPress.KeyChar == ')')
            {
                return false;
            }
            else if (Char.IsControl(pKeyPress.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

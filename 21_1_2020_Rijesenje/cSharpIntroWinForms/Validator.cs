using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public class Validator
    {
        public static bool ValidirajPolje(Control kontrola,ErrorProvider error,string Warning)
        {
            bool validno = true;
            if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validno = false;
            else if (kontrola is TextBox && string.IsNullOrEmpty((kontrola as TextBox).Text))
                validno = false;
            
            if(!validno)
            {
                error.SetError(kontrola, Warning);
                return false;
            }else
            {
                error.Clear();
                return true;
            }
        }
    }
}

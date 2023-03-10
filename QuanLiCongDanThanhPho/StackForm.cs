using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    static internal class StackForm
    {
        static private List<Form> forms = new List<Form>();
        static public FTrangChu fTrangChu;
        static public void Add(Form form)
        {
            forms.Add(form);
        }
        static bool Remove() 
        {
            if (forms.Count == 0) 
                return false;
            else
            {
                forms[forms.Count - 1].Close();
                forms.RemoveAt(forms.Count - 1);
            }
            return true;
        }
        static public void Back()
        {    
            if (Remove() && (forms.Count - 1 >= 0))
            {   
                forms[forms.Count - 1].BringToFront();
            }    
        }
        static public void ClearAll()
        {
            foreach (var form in forms) 
            {
                form.Close();
            }
            forms.Clear();
        }    
    }
}

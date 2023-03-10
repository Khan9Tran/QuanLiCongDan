using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        static public void RemoveForm()
        {
            forms[forms.Count - 1].Close();
            forms.RemoveAt(forms.Count - 1);
        }
        static public void Back()
        {
            if (forms.Count > 0)
            {
                RemoveForm();
                if (forms.Count > 0)
                    forms[forms.Count - 1].Show();
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

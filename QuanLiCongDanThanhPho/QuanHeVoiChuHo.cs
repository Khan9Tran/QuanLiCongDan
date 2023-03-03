using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class QuanHeVoiChuHo
    {
        private CongDan congDan;
        private string quanHeVoiChuHo;
        public QuanHeVoiChuHo() { }
        public QuanHeVoiChuHo(CongDan congDan, string quanHeVoiChuHo)
        {
            this.congDan = congDan;
            this.quanHeVoiChuHo = quanHeVoiChuHo;
        }
        internal CongDan CongDan { get => congDan; set => congDan = value; }
    }
}

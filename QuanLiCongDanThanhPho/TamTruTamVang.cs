using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class TamTruTamVang
    {
        private string maSo;
        private string trangThai;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private DiaChi diaChi;
        private string lyDo;

        public string MaSo { get { return maSo; }  }
        public string TangThai { get { return trangThai; } }
        public DateTime NgayBatDau { get { return ngayBatDau; } }
        public DateTime NgayKetThuc { get { return ngayKetThuc; } }
        public DiaChi SoDiaChi { get { return diaChi; } }
        public string LyDo { get { return lyDo; } }
    }
}

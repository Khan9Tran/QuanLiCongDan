using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho.Models
{
    internal class TamTruTamVang
    {
        private string maSo;
        private string trangThai;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private DiaChi diaChi;
        private string lyDo;
        public TamTruTamVang() { }
        public TamTruTamVang(string maSo, string trangThai, DateTime ngayBatDau, DateTime ngayKetThuc, string diaChi, string lyDo)
        {
            MaSo = maSo;
            TrangThai = trangThai;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DiaChi = new DiaChi();
            this.diaChi.DinhDang(diaChi);
            LyDo = lyDo;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        internal DiaChi DiaChi { get => diaChi; set => diaChi = value; }
    }
}

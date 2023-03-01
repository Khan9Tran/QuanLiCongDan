using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCongDanThanhPho
{
    internal class DiaChi
    {
        private string soDiaChi;
        private string soNha;
        private string duong;
        private string quanHuyen;
        private string tinhThanhPho;
        private string quocGia;

        public DiaChi(string soDiaChi, string soNha, string duong, string quanHuyen, string tinhThanhPho, string quocGia)
        {
            this.soDiaChi = soDiaChi;
            this.soNha = soNha;
            this.duong = duong;
            this.quanHuyen = quanHuyen;
            this.tinhThanhPho = tinhThanhPho;
            this.quocGia = quocGia;
        }

        public string SoDiaChi { get => soDiaChi; set => soDiaChi = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string Duong { get => duong; set => duong = value; }
        public string QuanHuyen { get => quanHuyen; set => quanHuyen = value; }
        public string TinhThanhPho { get => tinhThanhPho; set => tinhThanhPho = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }

        public string ToString()
        {
            string diaChi = $"{SoDiaChi}, {SoNha}, {Duong}, {QuanHuyen}, {TinhThanhPho}, {QuocGia}";
            return diaChi;
        }
    }
}

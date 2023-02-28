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

        public string SoDiaChi { get { return soDiaChi; } }
        public string SoNha { get { return soNha; } }
        public string Duong { get { return duong; } }
        public string QuanHuyen { get { return quanHuyen; } }
        public string TinhThanhPho { get { return tinhThanhPho; } }
        public string QuocGia { get { return quocGia; } }

        public string ToString()
        {
            string diaChi = $"{SoDiaChi}, {SoNha}, {Duong}, {QuanHuyen}, {TinhThanhPho}, {QuocGia}";
            return diaChi;
        }
    }
}

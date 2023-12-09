using DAO;
using DTO;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace BUS
{
    public class DanhGiaBUS
    {
        private static DanhGiaBUS instance;

        private DanhGiaBUS() { }

        public static DanhGiaBUS Instance
        {
            get
            {
                if (instance == null) instance = new DanhGiaBUS();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable Danhsachdanhgia()
        {       
            DataTable danhgia = DanhGiaDAO.Instance.danhsachdanhgia();
        
            return danhgia;
        }
        public void ThemDanhGia(DanhGiaDTO danhGia)
        {
           
         
        }

    }
}

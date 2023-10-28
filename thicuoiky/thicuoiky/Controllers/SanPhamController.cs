using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using thicuoiky.Models;

namespace thicuoiky.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities1 db = new CSDLTestEntities1();
        [HttpGet]
        public List<SanPham>  listAllSanPham()
        {
            return db.SanPhams.ToList();
        }
        [HttpGet]
        public List<SanPham> listSanPhamByDanhMuc(int madm)
        {
            return db.SanPhams.Where(sp => sp.DanhMuc == madm).ToList();
        }
        [HttpGet]
        public List<SanPham> listSanPhamById(int ma)
        {
            return db.SanPhams.Where(sp => sp.Ma == ma).ToList();
        }

        [HttpGet]
        public List<SanPham> listSanPhamByDonGia(int bd,int kt)
        {
            return db.SanPhams.Where(s =>  s.DonGia >= bd && s.DonGia <= kt).ToList();

        }

        [HttpPost]
        public bool addSanPham(int ma,string ten,int gia,int madm)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(s => s.Ma == ma);
            if (sp == null)
            {
                sp=new SanPham();
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.DanhMuc = madm;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                    return true;
            }
            return false;
        }
        [HttpPut]
        public bool updateSanPham(int ma,string ten,int gia,int madm)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(s => s.Ma == ma);
            if (sp != null)
            {
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.DanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool deleteSanPham(int ma)
        {
            
            SanPham sp = db.SanPhams.SingleOrDefault(s => s.Ma == ma);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        
    }
}

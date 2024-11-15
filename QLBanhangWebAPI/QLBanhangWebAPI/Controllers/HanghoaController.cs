using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBanhangWebAPI.ModelFromDB;

namespace QLBanhangWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HanghoaController : ControllerBase
    {
        CSDLBanHang dbc; // bien cuc bo

        // ham tao
        public HanghoaController(CSDLBanHang db)
        {
            dbc = db;
        }

        [HttpPost] 
        [Route("/Hanghoa/List")] // Ten phuong thuc se goi qua cac api: (diachiweb)/Hanghoa/List
        // lay du lieu
        public IActionResult GetList() // danh sach trong csdl
        {
            return Ok(new { data = dbc.TblHanghoas.ToList() });
        }

        [HttpPost]
        [Route("/Hanghoa/Insert")] // Ten phuong thuc se goi qua cac api: (diachiweb)/Hanghoa/List
        // them hang hoa
        public IActionResult themHanghoa(string ma, string ten, string donvi, double gianhap, double giaban) // danh sach trong csdl
        {
            TblHanghoa hh = new TblHanghoa();
            hh.Id=Guid.NewGuid(); // Tu sinh ID
            hh.Ma=ma;   
            hh.Ten=ten;
            hh.Donvi=donvi;
            hh.Gianhap=gianhap;
            hh.Giaban=giaban;
            dbc.TblHanghoas.Add(hh);
            dbc.SaveChanges();

            //tra ve ca mot cai danh sach
            //return Ok(new { data = dbc.TblHanghoas.ToList() });

            // tra ve dung cai da them
            return Ok(new {hh});

        }


        [HttpPost]
        [Route("/Hanghoa/Update")] // Ten phuong thuc se goi qua cac api: (diachiweb)/Hanghoa/List
        // update hang hoa
        public IActionResult capnhatHanghoa(string id, string ma, string ten, string donvi, double gianhap, double giaban) // danh sach trong csdl
        {
            TblHanghoa hh = new TblHanghoa();
            hh.Id = new Guid(id); // Tu sinh ID
            hh.Ma = ma;
            hh.Ten = ten;
            hh.Donvi = donvi;
            hh.Gianhap = gianhap;
            hh.Giaban = giaban;
            dbc.TblHanghoas.Update(hh);
            dbc.SaveChanges();

            // tra ve dung cai da them
            return Ok(new { hh });
            //return Ok(new { data = dbc.TblHanghoas.ToList() });
        }


        [HttpPost]
        [Route("/Hanghoa/Delete")] // Ten phuong thuc se goi qua cac api: (diachiweb)/Hanghoa/List
        // delete hang hoa
        public IActionResult xoa1bangghi(string id, string ma, string ten, string donvi, double gianhap, double giaban) // danh sach trong csdl
        {
            TblHanghoa hh = new TblHanghoa();
            hh.Id = new Guid(id); // Tu sinh ID
            dbc.TblHanghoas.Remove(hh);
            dbc.SaveChanges();
            return Ok(new { hh });
        }
    }

  
}

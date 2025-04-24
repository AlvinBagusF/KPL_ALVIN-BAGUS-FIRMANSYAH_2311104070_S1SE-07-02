using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_2311104070.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa { Nama = "Alvin Bagus Firmansyah", Nim = "2311104070" },
            new Mahasiswa { Nama = "Ahmad Al - Farizi", Nim = "2311104001" },
            new Mahasiswa { Nama = "Muhammad Shafiq Rasuna", Nim = "2311104002" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get() => daftarMahasiswa;

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= daftarMahasiswa.Count) return NotFound();
            return daftarMahasiswa[id];
        }

        [HttpPost]
        public IActionResult Post(Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok(mhs);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= daftarMahasiswa.Count) return NotFound();
            var mhs = daftarMahasiswa[id];
            daftarMahasiswa.RemoveAt(id);
            return Ok(mhs);
        }
    }

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}
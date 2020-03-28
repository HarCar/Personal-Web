using System;
using System.Threading.Tasks;

namespace Personal_Web.Models
{
    public class UsuariosRepository 
    {
        private DataContex contex;

        public UsuariosRepository(DataContex _contex) {
            contex = _contex;
        }

        public async Task<Usuarios> GetAsync()
        {
            //private SchoolContext db = new SchoolContext();
            //    return View(db.Students.ToList());
            DataContex db = new DataContex();
            var _usuarios = from c in db.Courses select new Usuarios() { ID = c.ID};

            return new _usuarios;
        }
    }
}
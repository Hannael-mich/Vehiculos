using DataVehiculos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVehiculos
{
    public class DatGrupo
    {
        Generacion23Entities db = new Generacion23Entities();
        public List<Grupo> Obtener()
        {
            //List<Productos1> ls = db.Productos1.ToList();
            List<Grupo> ls = db.Grupo.OrderBy(x =>x.Descripcion).ToList();
            db.Dispose();
            return ls;
        }
    }
}

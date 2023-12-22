using DataVehiculos;
using DataVehiculos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessVehiculos
{
    public class BusGrupo
    {
        public List<Grupo> Obtener()
        {
            return new DatGrupo().Obtener();
        }
    }
}

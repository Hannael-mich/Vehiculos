using DataVehiculos;
using DataVehiculos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessVehiculos
{
    public class BusVehiculos
    {
        DatProductos dat = new DatProductos();
        public List<Productos1> Obtener()
        {
            return dat.Obtener();
        }

        public Productos1 Obtener(string valor)
        {
            return dat.Obtener(valor);
        }

        public void Agregar (Productos1 p)
        {
            dat.Agregar(p);
        }
        public List<Productos1> Buscar(string valor)
        {
            return dat.Buscar(valor);
        }

        public void Editar(Productos1 p)
        {
            dat.Editar(p);
        }

        public void Borrar(Productos1 p)
        {
            dat.Borrar(p);
        }

        //public void ValidaProductoMarcaRepetido(Productos1 p)
        //{
        //    bool existe = dat.ValidaProductoMarcaRepetido(p);
        //    if (existe)
        //    {
        //        throw new Exception($"El producto {p.Productos} con esa marca ya esta registrado");
        //    }
        //}


    }
}

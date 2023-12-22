using DataVehiculos.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVehiculos
{
    public class DatProductos
    {
        Generacion23Entities db = new Generacion23Entities();

        public List<Productos1> Obtener()
        {
            List<Productos1> ls = db.Productos1.Include("Grupo").ToList();
            db.Dispose();
            return ls;
        }

        public Productos1 Obtener(string valor)
        {
            //List<Productos> ls = db.Productos.ToList();// Esta linea es paracida a un select * from productos
            Productos1 p = db.Productos1.Include("Grupo").Where(x => x.Productos == valor).FirstOrDefault(); ;// Es como un select pero con dos inner join
            db.Dispose();
            return p;
        }

        public void Agregar(Productos1 p)
        {
            db.Productos1.Add(p);
            db.SaveChanges();
            db.Dispose();

        }

        public void Editar(Productos1 p)
        {
            db.Productos1.AddOrUpdate(p);
            db.SaveChanges();
            db.Dispose();
        }

        public void Borrar(Productos1 p)
        {
            Productos1 pe = db.Productos1.Where(x => x.Productos == p.Productos).FirstOrDefault();//Delect...
            db.Productos1.Remove(pe);
            db.SaveChanges();
            db.Dispose();
        }

        public List<Productos1> Buscar(string valor)
        {
            //List<Productos> ls = db.Productos.ToList();// Esta linea es paracida a un select * from productos
            List<Productos1> ls = db.Productos1.Include("Grupo").Where(x => x.Productos.Contains(valor)
            || x.CveGpo.Contains(valor) || x.Estatus.Contains(valor) || x.Descripcion.Contains(valor)
            || (x.AñoInicio.ToString()).Contains(valor) || (x.AñoFin.ToString()).Contains(valor)
            || x.Proveedor.Contains(valor) || (x.Costo.ToString()).Contains(valor) || x.Grupo.Descripcion.Contains(valor)).ToList();// Es como un select pero con dos inner join
            db.Dispose();
            return ls;
        }
    }
}

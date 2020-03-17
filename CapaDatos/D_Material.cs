using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using CapaEntidades;
using System.IO;

namespace CapaDatos
{
    public class D_Material
    {
        SQLiteConnection sql_con = new SQLiteConnection();
        Conexion conexion = new Conexion();

        // Set loadDB
        public List<E_Material> LoadMateriales()
        {
            sql_con = conexion.SetConnection();
            sql_con.Open();
            //string consulta = "SELECT * FROM Materiales";            
            string consulta = "SELECT * FROM Materiales INNER JOIN Categorias ON Materiales.Categorias_idCategorias = Categorias.idCategoria";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql_con);
            int a = comando.ExecuteNonQuery();
            Console.WriteLine(a);
            SQLiteDataReader datos = comando.ExecuteReader();
            List<E_Material> Listar = new List<E_Material>();

            while (datos.Read())
            {
                Console.WriteLine(datos.GetString(9));
                Listar.Add(new E_Material
                {
                    IdMaterial = datos.GetInt32(0),
                    Codigo = datos.GetString(1),
                    Nombre = datos.GetString(2),
                    Descripcion = datos.GetString(3),
                    Existencia = datos.GetInt32(4),
                    Imagen = datos.GetString(5),
                    Estatus = datos.GetInt32(6),
                    Categorias_idCategoria = datos.GetInt32(7),
                    IdCategoria = datos.GetInt32(8),
                    NombreCategoria = datos.GetString(9),
                    EstatusCategoria = datos.GetInt32(10)
                });
            }

            sql_con.Close();
            return Listar;
        }
    }
}
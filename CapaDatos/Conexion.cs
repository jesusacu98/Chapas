using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        SQLiteConnection sql_con = new SQLiteConnection();
        SQLiteCommand comando = new SQLiteCommand();
        BD bd = new BD();

        //Hacer la conexion a la base de datos
        public SQLiteConnection SetConnection()
        {
            try
            {
                string fileName = "ChapasElevadores.db";
                if (File.Exists("ChapasElevadores.db"))
                {
                    Console.WriteLine("simon");
                    //Jesus
                    string fullPath;
                    string replace;
                    replace = Path.GetFullPath(fileName);
                    fullPath = replace.Replace(@"\", @"/");
                    fullPath = string.Format("Data Source={0}", fullPath);
                    Console.WriteLine(fullPath);
                    //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                    //    fileName, fullPath);
                    //"DataSource=C:/Users/AOC/Documents/GitHub/Solution1/CapaDatos/ChapasElevadores.db  \"
                    sql_con = new SQLiteConnection
                       (fullPath);

                    return sql_con;
                }
                else
                {
                    Console.WriteLine("nel");
                    SQLiteConnection.CreateFile("ChapasElevadores.db");
                    sql_con = new SQLiteConnection("DataSource=ChapasElevadores.db");
                    sql_con.Open();

                    comando = new SQLiteCommand(bd.TablaCategorias(), sql_con);
                    comando.ExecuteNonQuery();

                    comando = new SQLiteCommand(bd.TablaConfiguracion(), sql_con);
                    comando.ExecuteNonQuery();

                    comando = new SQLiteCommand(bd.TablaMateriales(), sql_con);
                    comando.ExecuteNonQuery();

                    comando = new SQLiteCommand(bd.TablaMovimientosMateriales(), sql_con);
                    comando.ExecuteNonQuery();

                    comando = new SQLiteCommand(bd.TablaUsuarios(), sql_con);
                    comando.ExecuteNonQuery();

                    string insertCategorias = "INSERT INTO Categorias (idCategoria, Nombre, Estatus) VALUES (@idCategoria, @Nombre, @Estatus)";
                    comando = new SQLiteCommand(insertCategorias, sql_con);
                    comando.Parameters.AddWithValue("@idCategoria", "1");
                    comando.Parameters.AddWithValue("@Nombre", "Nissan");
                    comando.Parameters.AddWithValue("@Estatus", "1");
                    comando.ExecuteNonQuery();

                    string insertMateriales = "INSERT INTO Materiales (idMaterial, Codigo, Nombre, Descripcion, Existencia, Imagen, Estatus, Categorias_idCategorias) VALUES (@idMaterial, @Codigo, @Nombre, @Descripcion, @Existencia, @Imagen, @Estatus, @Categorias_idCategorias)";
                    comando = new SQLiteCommand(insertMateriales, sql_con);
                    comando.Parameters.AddWithValue("@idMaterial", "1");
                    comando.Parameters.AddWithValue("@Codigo", "1234");
                    comando.Parameters.AddWithValue("@Nombre", "Manija");
                    comando.Parameters.AddWithValue("@Descripcion", "Repuesto para carro");
                    comando.Parameters.AddWithValue("@Existencia", "12");
                    comando.Parameters.AddWithValue("@Imagen", "prueba.jpg");
                    comando.Parameters.AddWithValue("@Estatus", "1");
                    comando.Parameters.AddWithValue("@Categorias_idCategorias", "1");
                    comando.ExecuteNonQuery();

                    sql_con.Close();

                    return sql_con;
                }                
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return sql_con;
            }
        }
    }
}

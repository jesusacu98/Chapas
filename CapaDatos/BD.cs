using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class BD
    {
        public string TablaCategorias()
        {
            string query = "CREATE TABLE Categorias (idCategoria INTEGER PRIMARY KEY AUTOINCREMENT, Nombre VARCHAR(45), Estatus INT)";
            return query;
        }

        public string TablaConfiguracion()
        {
            string query = "CREATE TABLE Configuracion (idConfiguracion INTEGER PRIMARY KEY AUTOINCREMENT, Descripcion VARCHAR(45), Estatus INT)";
            return query;
        }

        public string TablaMateriales()
        {
            string query = "CREATE TABLE Materiales (idMaterial INTEGER PRIMARY KEY AUTOINCREMENT, Codigo VARCHAR(15),Nombre VARCHAR(45), Descripcion NUMERIC, Existencia INT, Imagen NUMERIC, Estatus INT, Categorias_idCategorias INTEGER, FOREIGN KEY(Categorias_idCategorias) REFERENCES Categorias(idCategoria))";
            return query;
        }

        public string TablaMovimientosMateriales()
        {
            string query = "CREATE TABLE Movimientos_Materiales (idMovimiento INTEGER PRIMARY KEY AUTOINCREMENT, Entrada INT, Salida INT, Cantidad INT, Fecha DATETIME, Materiales_idMaterial INTEGER, FOREIGN KEY(Materiales_idMaterial) REFERENCES Materiales(idMaterial))";
            return query;
        }

        public string TablaUsuarios()
        {
            string query = "CREATE TABLE Usuarios (idUsuario INTEGER PRIMARY KEY AUTOINCREMENT, Nombre VARCHAR(45), Apellidos VARCHAR(45), Puesto VARCHAR(45), Usuario VARCHAR(8), Contraseña VARCHAR(8), Estatus INT)";
            return query;
        }
    }
}

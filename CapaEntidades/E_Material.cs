using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Material : E_Categoria
    {
        private int _idMaterial;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private int _Existencia;
        private string _Imagen;
        private int _Estatus;
        private int _Categorias_idCategoria;

        public E_Material(int idMaterial, string codigo, string nombre, string descripcion, int existencia, string imagen, int estatus, int categorias_idCategoria)
        {
            _idMaterial = idMaterial;
            _Codigo = codigo;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Existencia = existencia;
            _Imagen = imagen;
            _Estatus = estatus;
            _Categorias_idCategoria = categorias_idCategoria;
        }

        public E_Material()
        {
            _idMaterial = 0;
            _Codigo = "";
            _Nombre = "";
            _Descripcion = "";
            _Existencia = 0;
            _Imagen = "";
            _Estatus = 0;
            _Categorias_idCategoria = 0;
        }

        public int IdMaterial { get => _idMaterial; set => _idMaterial = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Existencia { get => _Existencia; set => _Existencia = value; }
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
        public int Categorias_idCategoria { get => _Categorias_idCategoria; set => _Categorias_idCategoria = value; }
    }
}
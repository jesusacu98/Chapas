using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Categoria
    {
        private int _idCategoria;
        private string _NombreCategoria;
        private int _estatusCategoria;

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string NombreCategoria { get => _NombreCategoria; set => _NombreCategoria = value; }
        public int EstatusCategoria { get => _estatusCategoria; set => _estatusCategoria = value; }

        public E_Categoria(int idCategoria, string nombreCategoria, int estatusCategoria)
        {
            _idCategoria = idCategoria;
            _NombreCategoria = nombreCategoria;
            _estatusCategoria = estatusCategoria;
        }

        public E_Categoria()
        {
            _idCategoria = 0;
            _NombreCategoria = "";
            _estatusCategoria = 0;
        }
    }
}

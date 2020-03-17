using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Material
    {
        D_Material objDato = new D_Material();

        public List<E_Material> ListandoMaterial()
        {
            return objDato.LoadMateriales();
        }
    }
}
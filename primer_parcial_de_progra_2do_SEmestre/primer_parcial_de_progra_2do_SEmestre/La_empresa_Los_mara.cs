using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_de_progra_2do_SEmestre
{
    class La_empresa_Los_mara
    {
        public La_empresa_Los_mara(int codigo, string nombre, string apellido, int nit, string direccion, int telefono, string nombrevendedor, int totalcompras)
        {
            this._codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nit = nit;
            this.direccion = direccion;
            this.Telefono = telefono;
            this.nombrevendedor = nombrevendedor;
            this.totalcompras = totalcompras;

            if (totalcompras <= 1500)
            {
                tpcliente = "CLIENTE NORMAL";
            }
            else if (totalcompras > 1501 && totalcompras < 5000)
            {
                tpcliente = "CLIENTE ESPECIAL";
            }
            else if (totalcompras > 5001)
            {
                tpcliente = "CLIENTE MAYORISTA";
            }
        }

        private int _codigo;
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int nit { get; set; }
        public string direccion { get; set; }
        public int Telefono { get; set; }
        public string nombrevendedor { get; set; }
        private string tpcliente { get; set; }
        public int totalcompras { get; set; }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public void mostrarDatos()
        {
            Console.WriteLine("\nCliente" + "\nCodigo: " + Codigo + "\nNombre Completo: " + nombre + "\nApellidos Completos: " + apellido + "\nNit: " + nit + "\nDireccion: " + direccion + "\nTelefono: " + Telefono + "\nNombre del Vendedor: " + nombrevendedor + "\nTotal de compras qeu ha consumido el cliente en la empresa: " + totalcompras + "\nTipo de Cliente: " + tpcliente);
        }
    }
}

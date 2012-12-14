using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.DTOs;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class Menu : DefaultView
    {
        private readonly RolHome home;
        private readonly Dictionary<string, string> funcionalidades = new Dictionary<string, string> { { "Cargar Crédito", "CargarCredito" },
        { "Comprar GiftCard", "ComprarGiftCard" }, { "Comprar Cupón", "ComprarCupon" }, { "Pedir Devolución", "PedirDevolucion" },
        { "Historial de Compra de Cupones", "HistorialDeCompra" }, { "Armar Cupón", "ArmarCupon" }, { "Registro de consumo de Cupón", "RegistroConsumo" },
        { "Publicar Cupón", "PublicarCupon" }, { "Facturación a Proveedor", "FacturarProveedor" }, { "Listado Estadístico", "ListadoEstadistico" }, { "ABM Cliente", "ABMCliente" },
        { "ABM Proveedor", "ABMProveedor" }, { "ABM Rol", "ABMRol" }, { "Modificar Usuario", "ABMUsuario" }, { "Cambiar Password", "CambiarPassword" } };

        public Menu()
        {
            InitializeComponent();
            this.home = HomeFactory.Rol;
            this.Setup();
        }

        private void Setup()
        {
            this.ValidarDatos();
            this.Text = "Menu";
            this.LoadFuncionalidades();
        }

        private void LoadFuncionalidades()
        {
            IEnumerable<Funcionalidad> listFuncionalidades = HomeFactory.Funcionalidad.FuncionalidadesPorRol(HomeFactory.Usuario.UsuarioActual.id_rol);
            foreach (var item in listFuncionalidades)
            {
                string redirect = funcionalidades[item.descripcion];
                this.menuStrip1.AddItem(item.descripcion, (sender, args) => FormCreator.Show(redirect));
            }
            if(HomeFactory.Usuario.UsuarioActual.id_rol != 1)
            this.menuStrip1.AddItem("Darse de Baja", (sender, args) => FormCreator.Show("DarDeBaja"));  
        }
             
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Redirect(new LoginView(new Usuario()));
        }

        private void ValidarDatos()
        {
            bool falta = false;
            var tipo = HomeFactory.Usuario.UsuarioActual.id_tipo_usuario;
            var usuario = HomeFactory.Usuario.UsuarioActual;
            if(tipo == CLIENTE)
            {
                var cliente = HomeFactory.Usuario.GetClienteById(usuario.id_usuario.ToString());
                if (Equals(cliente.cod_postal, 0))
                    falta = true;
                if (Equals(cliente.mail, ""))
                    falta = true;
                if (falta)
                    new ModificarCliente(cliente).ShowDialog();
            }
            if(tipo == PROVEEDOR)
            {
                var proveedor = HomeFactory.Usuario.GetProveedorById(usuario.id_usuario.ToString());
                if (Equals(proveedor.cod_postal, 0))
                    falta = true;
                if (Equals(proveedor.contacto_nombre, ""))
                    falta = true;
                if (falta)
                    new ModificarProveedor(proveedor).ShowDialog();
            }

        }
    }
}

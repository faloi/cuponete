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
        { "ABM Proveedor", "ABMProveedor" }, { "ABM Rol", "ABMRol" }, { "Dar de Baja", "DarDeBaja" }, { "Cambiar Password", "CambiarPassword"} };

        public Menu()
        {
            InitializeComponent();
            this.home = HomeFactory.Rol;
            this.Setup();
        }

        private void Setup()
        {
            this.Text = "Menu";
            this.LoadFuncionalidades();
        }

        private void LoadFuncionalidades()
        {
            IEnumerable<Funcionalidad> listFuncionalidades = HomeFactory.Funcionalidad.FuncionalidadesPorRol(HomeFactory.Usuario.UsuarioActual.id_rol);
            foreach (var item in listFuncionalidades)
            {
                string redirect = funcionalidades[item.descripcion];
                if ((Equals(item.descripcion, "Dar de Baja")) && (HomeFactory.Usuario.UsuarioActual.id_rol == 1))
                    this.menuStrip1.AddItem("Habilitar / Deshabilitar Usuario", (sender, args) => FormCreator.Show(redirect));
                else
                    this.menuStrip1.AddItem(item.descripcion, (sender, args) => FormCreator.Show(redirect));
            }
        }

    }
}

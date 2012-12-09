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
        private readonly Dictionary<string, string> funcionalidades = new Dictionary<string, string> { { "Cargar Crédito", "CargarCredito" }, { "Comprar GiftCard", "ComprarGiftCard" }, { "Comprar Cupón", "ComprarCupon" }, { "Pedir Devolución", "PedirDevolucion" }, { "Historial de Compra de Cupones", "HistorialDeCompra" }, { "Armar Cupón", "ArmarCupon" }, { "Registro de consumo de Cupón", "RegistroConsumo" }, { "Publicar Cupón", "PublicarCupon" }, { "Facturación a Proveedor", "ArmarCupon" }, { "Listado Estadístico", "ListadoEstadistico" } };

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
            IList<Funcionalidad> listFuncionalidades = this.home.Funcionalidades(HomeFactory.Usuario.UsuarioActual.id_rol);
            foreach (var item in listFuncionalidades)
            {
                string redirect = funcionalidades[item.descripcion];
                this.menuStrip1.AddItem(item.descripcion, (sender, args) => FormCreator.Show(redirect));
            }
        }

    }
}

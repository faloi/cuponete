using System.Windows.Forms;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public partial class HomeView : Form
    {
        private readonly UsuarioHome home;

        public HomeView()
        {
            this.InitializeComponent();

            this.home = HomeFactory.Usuario;

            this.Setup();
        }

        private void Setup()
        {
            var entries = this.home.UsuarioActual.Forms;

            foreach (var entry in entries)
                this.mainMenu.AddItem(entry.Key, (sender, args) => FormCreator.Show(entry.Value));
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

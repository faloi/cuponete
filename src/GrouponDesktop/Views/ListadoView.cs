using System.Windows.Forms;

namespace GrouponDesktop.Views
{
    public partial class ListadoView : DefaultView
    {
        private readonly BindingSource data;
        private readonly BindingSource example;

        protected ListadoView()
        {
            this.data = new BindingSource();
            this.example = new BindingSource();
        }

        protected object Data
        {
            get { return this.data; }
            set { this.data.DataSource = value; }
        }

        protected object Example
        {
            get { return this.example; }
            set { this.example.DataSource = value; }
        }

        protected object Filter
        {
            get { return this.example.DataSource;  }
        }
    }
}

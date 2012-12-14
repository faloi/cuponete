using System;
using System.Windows.Forms;
using GrouponDesktop.Helpers;
using GrouponDesktop.Homes;

namespace GrouponDesktop.Views
{
    public abstract partial class ListadoView<TModel, THome> : DefaultView where TModel : class where THome : Home
    {
        private readonly TextBox lookupTextbox;
        private readonly string lookupProperty;
        
        private readonly BindingSource data;
        private readonly BindingSource example;
        
        private Button submitButton;
        private Button limpiarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private DataGridView dataGrid;
        
        protected readonly THome home;

        protected ListadoView(TextBox lookupTextbox, string lookupProperty, Home home) : this(home)
        {
            this.lookupTextbox = lookupTextbox;
            this.lookupProperty = lookupProperty;
        }

        protected ListadoView(Home home)
        {
            this.data = new BindingSource();
            this.example = new BindingSource();
            this.home = home as THome;

            this.InitializeComponent();

            this.Setup();
        }

        protected abstract void Setup();

        protected TModel SelectedItem
        {
            get { return this.dataGrid.GetSelectedItem<TModel>(); }
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

        protected TModel Filter
        {
            get { return this.example.DataSource as TModel;  }
        }

        protected void CreateBindings(Button submitButton, DataGridView dataGrid)
        {
            this.CreateBindings(submitButton, new Button(), new Button(), new Button(), dataGrid);
        }

        protected void CreateBindings(Button submitButton,Button modificarButton, DataGridView dataGrid)
        {
            this.CreateBindings(submitButton, new Button(), modificarButton, new Button(), dataGrid);
        }

        protected void CreateBindings(Button submitButton, Button limpiarButton, Button modificarButton, Button eliminarButton, DataGridView dataGrid)
        {
            this.CreateBindings(submitButton);
            
            this.limpiarButton = limpiarButton;
            this.modificarButton = modificarButton;
            this.eliminarButton = eliminarButton;
            this.dataGrid = dataGrid;            

            this.ResetExample();
            dataGrid.AllowUserToAddRows = false;
            this.DisableActions();

            this.data.DataSourceChanged += this.DisableActionsIfNoResults;

            dataGrid.SelectionChanged +=
                (sender, args) => this.EnableActions();

            dataGrid.CellDoubleClick +=
                (sender, args) => this.PerformLookup();
            
            limpiarButton.Click +=
                (sender, args) => this.ResetExample();
        }

        private void DisableActionsIfNoResults(object sender, EventArgs eventArgs)
        {
            var source = sender as BindingSource;
            if (source.Count != 0) 
                return;
            
            this.DisableActions();

            if (source.DataSource != null)
                MessageFactory.Info("Su búsqueda no produjo ningún resultado");
        }

        private void EnableActions()
        {
            this.ChangeActionsState(true);
        }

        private void DisableActions()
        {
            this.ChangeActionsState(false);
        }

        private void ChangeActionsState(bool state)
        {
            this.modificarButton.Enabled = this.eliminarButton.Enabled = state;
        }

        private void ResetExample()
        {
            this.Data = null;
            this.Example = Activator.CreateInstance<TModel>();
        }

        private void PerformLookup()
        {
            if (this.lookupTextbox == null)
                return;

            var selectedItem = this.SelectedItem;
            lookupTextbox.SetTextFrom(selectedItem, lookupProperty);

            this.Close();
        }
    }
}

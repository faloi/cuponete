using System;
using System.Windows.Forms;

namespace GrouponDesktop.Views
{
    public abstract partial class ListadoView<T> : DefaultView where T : class
    {
        private readonly BindingSource data;
        private readonly BindingSource example;
        
        private Button submitButton;
        private Button limpiarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private DataGridView dataGrid;

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

        protected T Filter
        {
            get { return this.example.DataSource as T;  }
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
            
            limpiarButton.Click +=
                (sender, args) => this.ResetExample();
        }

        private void DisableActionsIfNoResults(object sender, EventArgs eventArgs)
        {
            var source = sender as BindingSource;
            if (source.Count == 0)
                this.DisableActions();
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
            this.Example = Activator.CreateInstance<T>();
        }
    }
}

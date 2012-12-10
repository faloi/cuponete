using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public sealed class DataType
    {
        private readonly string format;

        public static DataType INTEGER = new DataType("N0");
        public static DataType NUMBER = new DataType("N2");
        public static DataType CURRENCY = new DataType("C2");

        private DataType(string format)
        {
            this.format = format;
        }

        public override String ToString()
        {
            return this.format;
        }
    }

    public static class ControlBindingHelpers
    {
        public static void BindTextTo(this Control control, object model, string propertyName)
        {
            control.DataBindings.Add("Text", model, propertyName);
        }

        public static void BindTextTo(this Control control, object model, string propertyName, DataType dataType)
        {
            control.DataBindings.Add("Text", model, propertyName, true, DataSourceUpdateMode.OnPropertyChanged, null, dataType.ToString());
        }

        public static void BindTextToDate(this Control control, object model, string propertyName, string format)
        {
            var binding = new Binding("Text", model, propertyName);
            binding.Format += (sender, args) => args.Value = ((DateTime)args.Value).ToString(format);

            control.DataBindings.Add(binding);
        }

        public static void AddItem(this MenuStrip menu, string text, EventHandler onClick)
        {
            menu.Items.Add(text, null, onClick);
        }

        public static void BindSourceTo(this ListControl control, object model, string valueMember, string displayMember)
        {
            control.DataSource = model;
            control.ValueMember = valueMember;
            control.DisplayMember = displayMember;
        }

        public static void BindSourceTo(this DataGridView dataGrid, object model, string idField, Dictionary<string, string> columns)
        {
            dataGrid.BindSourceTo(model, columns);
            
            var idColumn = CreateDataGridViewColumn(new KeyValuePair<string, string>("id", idField));
            idColumn.Visible = false;

            dataGrid.Columns.Add(idColumn);
        }

        public static void BindSourceTo(this DataGridView dataGrid, object model, Dictionary<string, string> columns)
        {
            dataGrid.AutoGenerateColumns = false;
            dataGrid.DataSource = model;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Columns.Clear();

            var dataGridColumns = columns
                .Select(x => CreateDataGridViewColumn(x))
                .ToArray();
            
            dataGrid.Columns.AddRange(dataGridColumns);
        }

        private static DataGridViewColumn CreateDataGridViewColumn(KeyValuePair<string, string> x)
        {
            return new DataGridViewTextBoxColumn
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = x.Value, 
                HeaderText = x.Key, 
            };
        }

        public static string GetValue(this DataGridView dataGrid, string columnId)
        {
            return dataGrid.SelectedRows[0].Cells[columnId].Value as string;
        }

        public static IEnumerable<T> GetCheckedItems<T>(this CheckedListBox list)
        {
            return list.CheckedItems.Cast<T>();
        }
    }
}


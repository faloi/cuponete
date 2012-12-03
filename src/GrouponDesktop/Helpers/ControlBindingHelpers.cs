﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrouponDesktop.Helpers
{
    public static class ControlBindingHelpers
    {
        public static void BindTextTo(this Control control, object model, string propertyName)
        {
            control.DataBindings.Add("Text", model, propertyName);
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

        public static IEnumerable<T> GetCheckedItems<T>(this CheckedListBox list)
        {
            return list.CheckedItems.Cast<T>();
        }
    }
}


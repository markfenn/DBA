using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DowntownBoiseAssociation.Controls
{

    [DowntownBoiseAssociation.Controls.PropertyEditor(typeof(System.Object))]
    public partial class EditBase : UserControl, IPropertyUserInterface
    {
        public EditBase()
        {
            InitializeComponent();

       //     System.Reflection.Emit.EnumBuilder builder = new System.Reflection.Emit.EnumBuilder();

        }

        #region IPropertyUserInterface Members

        public int PropertyId { get; set; }

        public Type DataType { get; set; }
        
        public string Label
        {
            set
            {
                label1.Text = String.Format("{0}:",value);
            }
        }

        public string Value
        {
            get
            {
                return lblValue.Text;
            }
            set
            {
                lblValue.Text = value;
            }
        }

        #endregion
    }

    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PropertyEditor : System.Attribute
    {
        private System.Type forType;

        public PropertyEditor(System.Type ForType)
        {
            forType = ForType;
        }

        /// <summary>
        /// The type that this user control may edit
        /// </summary>
        public System.Type ForType
        {
            get { return forType; }
        }
    }

    public interface IPropertyUserInterface
    {
        int PropertyId { get; set; }
        string Label { set; }
        string Value { get; set; }
        Type DataType { get; set; }
    }

}

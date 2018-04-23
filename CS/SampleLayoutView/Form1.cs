using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Layout.Customization;
using DevExpress.XtraEditors;

namespace SampleLayoutView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myLayoutView1.ShowCustomization += new EventHandler(myLayoutView1_ShowCustomization);
        }

        void myLayoutView1_ShowCustomization(object sender, EventArgs e)
        {
            var btn = new SimpleButton();
            btn.Text = "New Button";
            btn.Location = new Point(250,9);
            myLayoutView1.CustomizationForm.Controls[0].Controls[0].Controls[1].Controls.Add(btn);
            btn.Select();
        }
    }
}

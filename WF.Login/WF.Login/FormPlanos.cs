using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Login
{
    public partial class FormPlanos : Form
    {

        public FormPlanos()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
           // dragging = true;
           // dragCursorPoint = Cursor.Position;
           // dragFormPoint = this.Location;
        }

        private void FormPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            //if (dragging)
            //{
            //    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            //    this.Location = Point.Add(dragFormPoint, new Size(dif));
            //}
        }

        private void FormPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            //dragging = false;
        }
    }
}

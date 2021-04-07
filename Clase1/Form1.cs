using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clase1
{
    //public class boton : System.Windows.Forms.Button
    //{
    //    //public override Color BackColor 
    //    //{ 
    //    //    get => base.BackColor; 
    //    //    set => base.BackColor = value; 
    //    //}
    //}
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Consigna: 5 Controles con eventos y propiedades cambiadas.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add();
            listBox1.MouseHover += ListBox1_MouseHover; 
        }

        private void ListBox1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.BackColor = Color.Red;

            else
                this.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void listBox1_StyleChanged(object sender, EventArgs e)
        {

        }
    }
}

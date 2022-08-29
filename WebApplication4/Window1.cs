
using System;
using Wisej.Web;

namespace WebApplication4
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            Wisej.Base.Cookie c = Wisej.Web.Application.Cookies.Get("test");
            if (c != null)
                textBox1.Text = c.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wisej.Base.Cookie c = Wisej.Web.Application.Cookies.Get("test");
            //if (c == null)
                Wisej.Web.Application.Cookies.Add("test", textBox1.Text);
            //else
            //    c.Value = textBox1.Text;
        }
    }
}

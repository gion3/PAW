using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Seminar3_1065
{

    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form formular = new Form();
            formular.SuspendLayout();
            formular.StartPosition = FormStartPosition.Manual;
            formular.FormBorderStyle = FormBorderStyle.Sizable;
            formular.Text = "Formular aplicatie Windows";

            formular.SetBounds(10, 10, 500, 500);

            Label lbl1 = new Label();
            lbl1.Text = "Eticheta detalii:";
            lbl1.Location = new Point(50, 50);
            lbl1.Size = new Size(120, 30);

            TextBox tb1 = new TextBox();
            tb1.Location = new Point(180, 50);
            tb1.Size = new Size(150, 30);

            Button btn1 = new Button()
            {
                Size = new Size(70, 40),
                Location = new Point(50, 150),
                Text = "Afiseaza"
            };
            Button btn2 = new Button()
            {
                Size = new Size(70, 40),
                Location = new Point(250, 150),
                Text = "Exit"
            };
            formular.Controls.Add(lbl1);
            formular.Controls.Add(tb1);
            formular.Controls.Add(btn1);
            formular.Controls.Add(btn2);
            formular.ResumeLayout();

            btn1.Click += (obj, s) =>
            {
                DialogResult rasp = MessageBox.Show
                    ("Text afisat",
                    "fereastra mesaj",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Stop);
                if (rasp == DialogResult.Cancel)
                    MessageBox.Show("Raspuns gresit!");
            };

            btn2.Click += (obj, s) =>
            {
                formular.Close();
            };

            Application.Run(formular);
        }
    }
}

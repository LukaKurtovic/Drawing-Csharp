using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV2
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black);
        
        Linija tren_lin;
        Kruznica tren_kruz;
        Kocka tren_kocka;
        Elipsa tren_elipsa;
        Queue<Elipsa> kolekcijaElipsi = new Queue<Elipsa>();
        Queue<Kocka> kolekcijaKocki = new Queue<Kocka>();
        Queue<Kruznica> kolekcijaKruznica = new Queue<Kruznica>();
        Queue<Linija> kolekcijaLinija = new Queue<Linija>();
        Graphics graphicsHelper;
        
        Boolean bMouseDown;
        
       

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            rbBlack.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbBlack.Checked) pen.Color = Color.Black;
            else if (rbBlue.Checked) pen.Color = Color.Blue;
            else pen.Color = Color.Red;
            if (rbCircle.Checked)
            {
                tren_kruz = new Kruznica();
                tren_kruz.koordinata1 = e.Location;
                tren_kruz.SetColor(pen.Color);
            }
           else if (rbLine.Checked)
            {
                tren_lin = new Linija();
                tren_lin.koordinata1 = e.Location;
                tren_lin.SetColor(pen.Color);
            }
            else if (rbSquare.Checked)
            {
                tren_kocka = new Kocka();
                tren_kocka.koordinata1 = e.Location;
                tren_kocka.SetColor(pen.Color);
            }
            else
            {
                tren_elipsa = new Elipsa();
                tren_elipsa.koordinata1 = e.Location;
                tren_elipsa.SetColor(pen.Color);
            }
            bMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbCircle.Checked)
            {
                tren_kruz.radijus = (tren_kruz.koordinata1.X - e.Location.X);
                kolekcijaKruznica.Enqueue(tren_kruz);
            }
            else if (rbLine.Checked)
            {
                tren_lin.koordinata2 = e.Location;
                kolekcijaLinija.Enqueue(tren_lin);
            }
            else if (rbSquare.Checked)
            {
                tren_kocka.koordinata2 = e.Location;
                kolekcijaKocki.Enqueue(tren_kocka);
            }
            else if (rbElipse.Checked)
            {
                tren_elipsa.koordinata2 = e.Location;
                kolekcijaElipsi.Enqueue(tren_elipsa);
            }


            foreach (Linija line in kolekcijaLinija)
            {
                pen.Color = line.GetColor();
                line.DrawGrafObj(graphicsHelper, pen);
            }
            
            foreach (Kruznica krug in kolekcijaKruznica)
            {
                pen.Color = krug.GetColor();
                krug.DrawGrafObj(graphicsHelper, pen);
            }

            foreach (Kocka kocka in kolekcijaKocki)
            {
                pen.Color = kocka.GetColor();
                kocka.DrawGrafObj(graphicsHelper, pen);
            }

            foreach (Elipsa elipsa in kolekcijaElipsi)
            {
                pen.Color = elipsa.GetColor();
                elipsa.DrawGrafObj(graphicsHelper, pen);
            }
            bMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (bMouseDown)
            {
                if (rbCircle.Checked)
                {
                    tren_kruz.radijus = (tren_kruz.koordinata1.X - e.Location.X);
                    tren_kruz.DrawGrafObj(graphicsHelper, pen);
                    this.Invalidate();
                }
                else if (rbLine.Checked)
                {
                    tren_lin.koordinata2 = e.Location;
                    tren_lin.DrawGrafObj(graphicsHelper, pen);
                    this.Invalidate();
                }
                else if (rbSquare.Checked)
                {
                    tren_kocka.koordinata2 = e.Location;
                    tren_kocka.DrawGrafObj(graphicsHelper, pen);
                    this.Invalidate();
                }
                else if (rbElipse.Checked)
                {
                    tren_elipsa.koordinata2 = e.Location;
                    tren_elipsa.DrawGrafObj(graphicsHelper, pen);
                    this.Invalidate();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Linija line in kolekcijaLinija)
            {               
                line.DrawGrafObj(graphicsHelper, pen);
            }
            
            foreach (Kruznica krug in kolekcijaKruznica)
            {  
                krug.DrawGrafObj(graphicsHelper, pen);
            }

            foreach (Kocka kocka in kolekcijaKocki)
            {
                kocka.DrawGrafObj(graphicsHelper, pen);
            }

            foreach(Elipsa elipsa in kolekcijaElipsi)
            {
                elipsa.DrawGrafObj(graphicsHelper, pen);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           graphicsHelper = this.CreateGraphics();
           bMouseDown = false;
            
        }

        private void gbShape_Enter(object sender, EventArgs e)
        {

        }
    }
}

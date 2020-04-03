using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal_Structures
{
    public partial class Form1 : Form
    {
        // Program for fractal structures by Iterated Function Systems (IFS)
        // 
        // Keeping Form1 as lean as possible all Form-methodes are in class "MainMethodes"
        // Description of junping particle in methode OutPut (see MainMethods)
        // QR-code from Code-Bude, see e.g. GitHub

        // S.N.U.F 27.03.2020
        // Last change: 03.04.2020

        // Version 1.0:
        // Async mode for growth-methode due to long-term calculation of motion freezing windows (here not the case but standard)
        // Draw graphic in image of picturebox -> graphic is always visible after mooving behind other windows etc.
        // Necessary for refreshing image: Invalidate methode

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Generation of MainMathode instance
            MainMethods Ausgabe1 = new MainMethods();
            //  Implementation of QR-code to Form1
            Ausgabe1.Create_QRCode(this, "MIT Licence\nCopyright (c) 2020 SNUF2020\n\nhttps://github.com/SNUF2020");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Program-End with Exit-Button

        private async void button_Start_Click(object sender, EventArgs e)
        {
            // Generation of MainMathode instance
            MainMethods Ausgabe = new MainMethods();
            
            // Definition and Initiation
            Random rand = new Random(); // generation of instance of Random-class. in case of (number) = defined random value
            int size = 500;             // definition of scale of playground 
            
            // Definition of output window and return control instance 
            Control outputWin = Ausgabe.OutPut_Window(size); // return Graphics instance for further use

            // Generation of PicturBox (w/ image) for graphic plotted in
            PictureBox Field = Ausgabe.GenPicBox(outputWin, size);

            // Generation of Graphics instance correlated to image in picturebox
            Graphics g = Graphics.FromImage(Field.Image);
            
            // Generation of playground
            Point[] playground = Ausgabe.PlayGround(g, size, radioButton_Sirpinski_3rand, radioButton_SquarNoice, radioButton_noRes_23,
                radioButton_SquareRest1, radioButton_SquareRest2, radioButton_SquareRest3, radioButton_CenterPoint_13,  radioButton_CenterPoint_23);

            // Definition of restriction etc.
            double [] para = Ausgabe.Para(radioButton_Sirpinski_3rand, radioButton_SquarNoice, radioButton_noRes_23, radioButton_SquareRest1,
                radioButton_SquareRest2, radioButton_SquareRest3, radioButton_CenterPoint_13, radioButton_CenterPoint_23, radioButton_secLast, 
                radioButton_3rdLast);

            // Definition of color
            SolidBrush[] Farbe = Ausgabe.Farbe(radioButton_non);

            // Simulate growth
           await Task.Run(() => Ausgabe.OutPut(Field, g, rand, playground, size, para, Farbe));
            // methode running in async mode -> no freezing of desktop due to long-time calculation duration of this methode

            // Dispose graphic instance
            g.Dispose();


        }
    } // Form
}

using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;


namespace Fractal_Structures
{
    class MainMethods
    {
        public void Create_QRCode(Control ctrl, string payload)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator(); // creating an instance of the QR-Code-Generator 
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            // generating bitmap e.g. for forms
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(2);
            PictureBox P = new PictureBox()
            {
                Size = new Size(120, 120),
                Location = new Point(63, 310),
            };
            ctrl.Controls.Add(P);
            P.Image = qrCodeImage;
        }
        public Control OutPut_Window(int size)
        {
            Form w1 = new Form();
            w1.Text = "Output Window";                          // Set the caption bar text of the form w1.   
            w1.MaximizeBox = false;                             // Set the MaximizeBox to false to remove the maximize box.
            w1.MinimizeBox = false;                             // Set the MinimizeBox to false to remove the minimize box.
            w1.StartPosition = FormStartPosition.CenterScreen;  // Set the start position of the form to the center of the screen.
            w1.AutoSize = false;
            w1.Size = new Size(size+60, size+100);
            w1.Show();             // show form w1
            return w1;
        }
        public PictureBox GenPicBox(Control ctrl, int size)
        {
            PictureBox Field = new PictureBox()
            {
                Size = new Size(size+40, size+100)
            };
            Bitmap FieldBitmap = new Bitmap(size+40, size+100, PixelFormat.Format32bppArgb);
            //FieldBitmap.SetResolution(50.0F, 50.0F);
            Field.Image = FieldBitmap;
            ctrl.Controls.Add(Field);
            return Field;
        }
        public void Message(int size, string info, Graphics gr, Single x, Single y)
        {
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            StringFormat drawFormat = new System.Drawing.StringFormat();
            gr.DrawString(info, drawFont, drawBrush, x, y, drawFormat);
        }
        public Point[] PlayGround(Graphics gr, int Size, RadioButton radioButton_Sirpinski_3rand, RadioButton radioButton_SquarNoice,
            RadioButton radioButton_SquareRest1, RadioButton radioButton_CenterPoint_13, RadioButton radioButton_CenterPoint_23)
        {
            Point topLeft = new Point(20, 40);
            Point topRight = new Point(20+Size, 40);
            Point downLeft = new Point(20, 40+Size);
            Point downRight = new Point(20+Size, 40+Size);
            Point center = new Point(Size / 2 + 20, Size / 2 + 40);
            Point mid_up = new Point(Size / 2 + 20, 40);
            Point mid_left = new Point(20, Size / 2 + 40);
            Point mid_right = new Point(Size + 20, Size / 2 + 40);
            Point mid_down = new Point(Size / 2 + 20, Size + 40);

            Point[] playGround;

            if (radioButton_Sirpinski_3rand.Checked)
            {
                Message(14, "Sierpiński Triangle", gr, 20, 10);
                // 3 Dots
                playGround = new Point[] { mid_up, downLeft, downRight };
                return playGround;
            }
            else if (radioButton_SquarNoice.Checked)
            {
                Message(14, "White Noise", gr, 20, 10);
                playGround = new Point[] { topLeft, topRight, downLeft, downRight };
                return playGround;
            }
            else if (radioButton_SquareRest1.Checked)
            {
                Message(14, "Structure w/o Name", gr, 20, 10);
                playGround = new Point[] { topLeft, topRight, downLeft, downRight };
                return playGround;
            }
            else if (radioButton_CenterPoint_13.Checked)
            {
                Message(14, "Vicsek Fractal", gr, 20, 10);
                playGround = new Point[] { topLeft, topRight, downLeft, downRight, center };
                return playGround;
            }
            else //(radioButton_CenterPoint_23.checked)
            {
                Message(14, "Sierpiński Carpet", gr, 20, 10);
                playGround = new Point[] { topLeft, topRight, downLeft, downRight, mid_up, mid_down, mid_left, mid_right};
                return playGround;
            }
        }
        public double[] Para (RadioButton radioButton_Sirpinski_3rand, RadioButton radioButton_SquarNoice,
            RadioButton radioButton_SquareRest1, RadioButton radioButton_CenterPoint_13, RadioButton radioButton_CenterPoint_23, 
            RadioButton radioButton_secLast, RadioButton radioButton_3rdLast)
        {
            double[] Para = new double [3];
            if (radioButton_Sirpinski_3rand.Checked)
            {
                Para[0] = 2; // JumpLength
                Para[1] = 0; // Restriction
                //return Para;
            }
            else if (radioButton_SquarNoice.Checked)
            {
                Para[0] = 2; // JumpLength
                Para[1] = 0; // Restriction
                //return Para;
            }
            else if (radioButton_SquareRest1.Checked)
            {
                Para[0] = 2; // JumpLength
                Para[1] = 1; // Restriction
                //return Para;
            }
            else if (radioButton_CenterPoint_13.Checked)
            {
                Para[0] = 1.5; // JumpLength
                Para[1] = 0; // Restriction
                //return Para;
            }
            else if (radioButton_CenterPoint_23.Checked)
            {
                Para[0] = 1.5; // JumpLength
                Para[1] = 0; // Restriction
                //return Para;
            }
            if (radioButton_secLast.Checked)
            {
                Para[2] = 2; // Coloring
                //return Para;
            }
            else if (radioButton_3rdLast.Checked)
            {
                Para[2] = 3; // Coloring
            }
            else
            {
                Para[2] = 1; // Coloring
            }
            return Para;
        }
       
        public SolidBrush[] Farbe(RadioButton radioButton_non)
        {
            SolidBrush Brush1 = new SolidBrush(Color.Red);
            SolidBrush Brush2 = new SolidBrush(Color.Green);
            SolidBrush Brush3 = new SolidBrush(Color.Blue);
            SolidBrush Brush4 = new SolidBrush(Color.Lime);
            SolidBrush Brush5 = new SolidBrush(Color.LightBlue);
            SolidBrush Brush6 = new SolidBrush(Color.Cyan);
            SolidBrush Brush7 = new SolidBrush(Color.Plum);
            SolidBrush Brush8 = new SolidBrush(Color.Black);

            SolidBrush[] _color = new SolidBrush[8];

            if (radioButton_non.Checked)
            {
                for(int i = 0; i<8; i++)
                     _color[i] = new SolidBrush(Color.Black);
            }
            else 
            {
                _color[0] = new SolidBrush(Color.Red);
                _color[1] = new SolidBrush(Color.Green);
                _color[2] = new SolidBrush(Color.Blue);
                _color[3] = new SolidBrush(Color.Lime);
                _color[4] = new SolidBrush(Color.LightBlue);
                _color[5] = new SolidBrush(Color.Cyan);
                _color[6] = new SolidBrush(Color.Plum);
                _color[7] = new SolidBrush(Color.Black);

            }
            return _color;
        }
        public void OutPut(PictureBox picbox, Graphics gr, Random rnd, Point[] PlayGround, int size, double[] para, SolidBrush[] Farbe)
        {
            Point Punkt = new Point(size / 2, size / 2);

            SolidBrush LastColor = Farbe[0];
            SolidBrush SecLastColor = Farbe[0];

            int direction = 1;
            int last_dir = 1;
            int help = 0; // help variable for color definition (at second switch)
            // throw away first points (to get better convergation)
            for (int k = 0; k < 1000000; k++)
            { 
                direction = rnd.Next(1, PlayGround.Length + 1);
                // any restriction?
                if (para[1] > 0)
                {
                    if (direction == last_dir)
                        direction = direction + 1;
                    if (direction > PlayGround.Length)
                        direction = 1;
                }
                last_dir = direction;
                // random junp
                switch (direction)
                {
                    case 1: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[0].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[0].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 2: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[1].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[1].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 3: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[2].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[2].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 4: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[3].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[3].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 5: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[4].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[4].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 6: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[5].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[5].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 7: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[6].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[6].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 8: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[7].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[7].Y - (double)Punkt.Y) / para[0]);
                        break;
                    case 9: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[8].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[8].Y - (double)Punkt.Y) / para[0]);
                        break;

                }
            }
            // plot now fractal structure
            for (int k = 0; k < 200000; k++)
            {
                direction = rnd.Next(1, PlayGround.Length + 1);
                // any restriction?
                if (para[1] > 0)
                {
                    if (direction == last_dir)
                        direction = direction + 1;
                    if (direction > PlayGround.Length)
                        direction = 1;
                }
                last_dir = direction;
                // random junp
                switch (direction)
                {
                    case 1:
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[0].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[0].Y - (double)Punkt.Y) / para[0]);
                        help = 0;
                        break;
                    case 2: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[1].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[1].Y - (double)Punkt.Y) / para[0]);
                        help = 1;
                        break;
                    case 3: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[2].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[2].Y - (double)Punkt.Y) / para[0]);
                        help = 2;
                        break;
                    case 4: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[3].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[3].Y - (double)Punkt.Y) / para[0]);
                        help = 3;
                        break;
                    case 5: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[4].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[4].Y - (double)Punkt.Y) / para[0]);
                        help = 4;
                        break;
                    case 6: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[5].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[5].Y - (double)Punkt.Y) / para[0]);
                        help = 5;
                        break;
                    case 7: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[6].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[6].Y - (double)Punkt.Y) / para[0]);
                        help = 6;
                        break;
                    case 8: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[7].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[7].Y - (double)Punkt.Y) / para[0]);
                        help = 7;
                        break;
                    case 9: 
                        Punkt.X = Convert.ToInt32(Punkt.X + (PlayGround[8].X - (double)Punkt.X) / para[0]);
                        Punkt.Y = Convert.ToInt32(Punkt.Y + (PlayGround[8].Y - (double)Punkt.Y) / para[0]);
                        help = 8;
                        break;
                }
                // plot of right color schema
                if (para[2] == 1)
                    gr.FillRectangle(Farbe[help], Punkt.X, Punkt.Y, 1, 1);
                else if (para[2] == 2)
                    gr.FillRectangle(LastColor, Punkt.X, Punkt.Y, 1, 1);
                else 
                    gr.FillRectangle(SecLastColor, Punkt.X, Punkt.Y, 1, 1);
                
                SecLastColor = LastColor;
                LastColor = Farbe[direction - 1];
                
                picbox.Invalidate(); // update image in picturBox
            }
        }// Methode, first overload: random jump of particle
    }
}

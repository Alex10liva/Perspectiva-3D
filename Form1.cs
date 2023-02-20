namespace Perspectiva_3D
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Point l1, l2, l3, l4;
        Point origen;
        int width, height, wMid, hMid;
        Pen marcadorS = new Pen(Color.White, 3);
        Pen marcadorL = new Pen(Color.Wheat, 1);

        PointF squareA, squareB, squareC, squareD, squareE, squareF, squareG, squareH;
        bool ejeX, ejeY, ejeZ, all;

        double[] P1r, P2r, P3r, P4r;
        double[] P5r, P6r, P7r, P8r;

        double[] P1p, P2p, P3p, P4p;
        double[] P5p, P6p, P7p, P8p;

        Vertex P1, P2, P3, P4, P5, P6, P7, P8;
        Figures cube1, cube2;
        Scene scene;

        double angle = 0;
        double angleConverted;

        public Form1()
        {
            InitializeComponent();
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            wMid = width / 2;
            hMid = height / 2;
            origen = new Point(wMid, hMid);
            angleConverted = angle * (Math.PI / 180);
            InitializePictureBox(width, height);
            Init();
        }

        private void Init()
        {
            //Fornt side cube 1
            P1 = new Vertex(-1, -1, 1);
            P2 = new Vertex(1, -1, 1);
            P3 = new Vertex(1, 1, 1);
            P4 = new Vertex(-1, 1, 1);

            //Back side cube 1
            P5 = new Vertex(-1, -1, -1);
            P6 = new Vertex(1, -1, -1);
            P7 = new Vertex(1, 1, -1);
            P8 = new Vertex(-1, 1, -1);
            cube1 = new Figures(P1, P2, P3, P4, P5, P6, P7, P8);

            //Fornt side cube 2
            //P1 = new Vertex(-1.5, -1.5, 1.5);
            //P2 = new Vertex(1.5, -1.5, 1.5);
            //P3 = new Vertex(1.5, 1.5, 1.5);
            //P4 = new Vertex(-1.5, 1.5, 1.5);

            //Back side cube 2
            //P5 = new Vertex(-1.5, -1.5, -1.5);
            //P6 = new Vertex(1.5, -1.5, -1.5);
            //P7 = new Vertex(1.5, 1.5, -1.5);
            //P8 = new Vertex(-1.5, 1.5, -1.5);
            //cube2 = new Figures(P1, P2, P3, P4, P5, P6, P7, P8);

            // Create scene
            scene = new Scene();

            // Add cubes to the scene
            scene.Cubes.Add(cube1);
            //scene.Cubes.Add(cube2);

            if (scene.Cubes.Count() > 1)
            {
                label1.Location = new Point(225, 4);
                label1.Text = "Cambiar tamaño de los cuadrados";
            }
            else label1.Text = "Cambiar tamaño del cuadrado";

            InitFigures();
        }

        private void InitializePictureBox(int width, int height)
        {
            // Initialize bitmap
            bmp = new Bitmap(width, height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);

            // points to draw intersecting lines (center of the picture box)
            l1 = new Point(origen.X, 0);
            l2 = new Point(origen.X, height);
            l3 = new Point(0, origen.Y);
            l4 = new Point(width, origen.Y);

            // Draw intersecting lines
            g.DrawLine(marcadorL, l1, l2);
            g.DrawLine(marcadorL, l3, l4);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            // Draw the figures every time the trackbar is scrolled
            if (!ejeX && !ejeY && !ejeZ && !all)
            {
                InitializePictureBox(width, height);
                InitFigures();
            }
        }

        private void ButtonEjeX_Click(object sender, EventArgs e)
        {
            // Start the timer
            if (!Timer.Enabled)
                Timer.Start();
            // Indicate that it will rotate on the x axis
            all = false;
            ejeX = true;
            ejeY = false;
            ejeZ = false;
        }

        private void ButtonEjeY_Click(object sender, EventArgs e)
        {
            // Start the timer
            if (!Timer.Enabled)
                Timer.Start();
            // Indicate that it will rotate on the y axis
            all = false;
            ejeX = false;
            ejeY = true;
            ejeZ = false;
        }

        private void ButtonEjeZ_Click(object sender, EventArgs e)
        {
            // Start the timer
            if (!Timer.Enabled)
                Timer.Start();
            // Indicate that it will rotate on the z axis
            all = false;
            ejeX = false;
            ejeY = false;
            ejeZ = true;
        }

        private void ButtonTodos_Click(object sender, EventArgs e)
        {
            // Start the timer
            if(!Timer.Enabled)
                Timer.Start();
            // Indicate that it will rotate on all axes
            all = true;
            ejeX = false;
            ejeY = false;
            ejeZ = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increment the angle and convert it
            angle += 1;
            angleConverted = angle * (Math.PI / 180);
            InitializePictureBox(width, height);

            // Rotate the cube depending on which button was pressed
            if (ejeX)
                RotateX();
            if (ejeY)
                RotateY();
            if (ejeZ)
                RotateZ();
            if (all)
                RotateAll();
        }

        private void InitFigures()
        {
            // For all the cubes in the scene initialize them in the picutre box
            for (int i = 0; i < scene.Cubes.Count(); i++)
            {
                //Front side proyection
                P1p = Proyection(scene.Cubes[i].P1, 3);
                P2p = Proyection(scene.Cubes[i].P2, 3);
                P3p = Proyection(scene.Cubes[i].P3, 3);
                P4p = Proyection(scene.Cubes[i].P4, 3);

                //Back side proyection
                P5p = Proyection(scene.Cubes[i].P5, 3);
                P6p = Proyection(scene.Cubes[i].P6, 3);
                P7p = Proyection(scene.Cubes[i].P7, 3);
                P8p = Proyection(scene.Cubes[i].P8, 3);

                // Points to draw the square, front side
                squareA = new PointF((float)P1p[0], (float)P1p[1]);
                squareB = new PointF((float)P2p[0], (float)P2p[1]);
                squareC = new PointF((float)P3p[0], (float)P3p[1]);
                squareD = new PointF((float)P4p[0], (float)P4p[1]);

                // Points to draw the square, back side
                squareE = new PointF((float)P5p[0], (float)P5p[1]);
                squareF = new PointF((float)P6p[0], (float)P6p[1]);
                squareG = new PointF((float)P7p[0], (float)P7p[1]);
                squareH = new PointF((float)P8p[0], (float)P8p[1]);

                DrawFigure();
            }
        }

        private void RotateX()
        {
            // For all the cubes in the scene draw them in the picutre box
            for (int i = 0; i < scene.Cubes.Count(); i++)
            {
                //Front side rotation x axis
                P1r = RotationX(scene.Cubes[i].P1, angleConverted);
                P2r = RotationX(scene.Cubes[i].P2, angleConverted);
                P3r = RotationX(scene.Cubes[i].P3, angleConverted);
                P4r = RotationX(scene.Cubes[i].P4, angleConverted);

                //Back side  rotation x axis
                P5r = RotationX(scene.Cubes[i].P5, angleConverted);
                P6r = RotationX(scene.Cubes[i].P6, angleConverted);
                P7r = RotationX(scene.Cubes[i].P7, angleConverted);
                P8r = RotationX(scene.Cubes[i].P8, angleConverted);

                //Front side proyection
                P1p = Proyection(P1r, 3);
                P2p = Proyection(P2r, 3);
                P3p = Proyection(P3r, 3);
                P4p = Proyection(P4r, 3);

                //Back side proyection
                P5p = Proyection(P5r, 3);
                P6p = Proyection(P6r, 3);
                P7p = Proyection(P7r, 3);
                P8p = Proyection(P8r, 3);

                // Points to draw the square, front side
                squareA = new PointF((float)P1p[0], (float)P1p[1]);
                squareB = new PointF((float)P2p[0], (float)P2p[1]);
                squareC = new PointF((float)P3p[0], (float)P3p[1]);
                squareD = new PointF((float)P4p[0], (float)P4p[1]);

                // Points to draw the square, back side
                squareE = new PointF((float)P5p[0], (float)P5p[1]);
                squareF = new PointF((float)P6p[0], (float)P6p[1]);
                squareG = new PointF((float)P7p[0], (float)P7p[1]);
                squareH = new PointF((float)P8p[0], (float)P8p[1]);

                DrawFigure();
            }
        }

        private void RotateY()
        {
            // For all the cubes in the scene draw them in the picutre box
            for (int i = 0; i < scene.Cubes.Count(); i++)
            {
                //Front side rotation in y axis
                P1r = RotationY(scene.Cubes[i].P1, angleConverted);
                P2r = RotationY(scene.Cubes[i].P2, angleConverted);
                P3r = RotationY(scene.Cubes[i].P3, angleConverted);
                P4r = RotationY(scene.Cubes[i].P4, angleConverted);

                //Back side rotation in y axis
                P5r = RotationY(scene.Cubes[i].P5, angleConverted);
                P6r = RotationY(scene.Cubes[i].P6, angleConverted);
                P7r = RotationY(scene.Cubes[i].P7, angleConverted);
                P8r = RotationY(scene.Cubes[i].P8, angleConverted);

                //Front side proyection
                P1p = Proyection(P1r, 3);
                P2p = Proyection(P2r, 3);
                P3p = Proyection(P3r, 3);
                P4p = Proyection(P4r, 3);

                //Back side proyection
                P5p = Proyection(P5r, 3);
                P6p = Proyection(P6r, 3);
                P7p = Proyection(P7r, 3);
                P8p = Proyection(P8r, 3);

                // Points to draw the square, front side
                squareA = new PointF((float)P1p[0], (float)P1p[1]);
                squareB = new PointF((float)P2p[0], (float)P2p[1]);
                squareC = new PointF((float)P3p[0], (float)P3p[1]);
                squareD = new PointF((float)P4p[0], (float)P4p[1]);

                // Points to draw the square, back side
                squareE = new PointF((float)P5p[0], (float)P5p[1]);
                squareF = new PointF((float)P6p[0], (float)P6p[1]);
                squareG = new PointF((float)P7p[0], (float)P7p[1]);
                squareH = new PointF((float)P8p[0], (float)P8p[1]);

                DrawFigure();
            }
        }

        private void RotateZ()
        {
            // For all the cubes in the scene draw them in the picutre box
            for (int i = 0; i < scene.Cubes.Count(); i++)
            {
                //Front side rotation in z axis
                P1r = RotationZ(scene.Cubes[i].P1, angleConverted);
                P2r = RotationZ(scene.Cubes[i].P2, angleConverted);
                P3r = RotationZ(scene.Cubes[i].P3, angleConverted);
                P4r = RotationZ(scene.Cubes[i].P4, angleConverted);

                //Back side rotation in z axis
                P5r = RotationZ(scene.Cubes[i].P5, angleConverted);
                P6r = RotationZ(scene.Cubes[i].P6, angleConverted);
                P7r = RotationZ(scene.Cubes[i].P7, angleConverted);
                P8r = RotationZ(scene.Cubes[i].P8, angleConverted);

                //Front side proyection
                P1p = Proyection(P1r, 3);
                P2p = Proyection(P2r, 3);
                P3p = Proyection(P3r, 3);
                P4p = Proyection(P4r, 3);

                //Back side proyection
                P5p = Proyection(P5r, 3);
                P6p = Proyection(P6r, 3);
                P7p = Proyection(P7r, 3);
                P8p = Proyection(P8r, 3);

                // Points to draw the square, front side
                squareA = new PointF((float)P1p[0], (float)P1p[1]);
                squareB = new PointF((float)P2p[0], (float)P2p[1]);
                squareC = new PointF((float)P3p[0], (float)P3p[1]);
                squareD = new PointF((float)P4p[0], (float)P4p[1]);

                // Points to draw the square, back side
                squareE = new PointF((float)P5p[0], (float)P5p[1]);
                squareF = new PointF((float)P6p[0], (float)P6p[1]);
                squareG = new PointF((float)P7p[0], (float)P7p[1]);
                squareH = new PointF((float)P8p[0], (float)P8p[1]);

                DrawFigure();
            }
        }

        private void RotateAll()
        {
            // For all the cubes in the scene draw them in the picutre box
            for (int i = 0; i < scene.Cubes.Count(); i++)
            {
                //Front side rotation in x axis
                P1r = RotationX(scene.Cubes[i].P1, angleConverted);
                P2r = RotationX(scene.Cubes[i].P2, angleConverted);
                P3r = RotationX(scene.Cubes[i].P3, angleConverted);
                P4r = RotationX(scene.Cubes[i].P4, angleConverted);

                //Back side rotation in x axis
                P5r = RotationX(scene.Cubes[i].P5, angleConverted);
                P6r = RotationX(scene.Cubes[i].P6, angleConverted);
                P7r = RotationX(scene.Cubes[i].P7, angleConverted);
                P8r = RotationX(scene.Cubes[i].P8, angleConverted);

                //Front side rotation in y axis
                P1r = RotationY(P1r, angleConverted);
                P2r = RotationY(P2r, angleConverted);
                P3r = RotationY(P3r, angleConverted);
                P4r = RotationY(P4r, angleConverted);

                //Back side rotation in y axis
                P5r = RotationY(P5r, angleConverted);
                P6r = RotationY(P6r, angleConverted);
                P7r = RotationY(P7r, angleConverted);
                P8r = RotationY(P8r, angleConverted);

                //Front side rotation in z axis
                P1r = RotationZ(P1r, angleConverted);
                P2r = RotationZ(P2r, angleConverted);
                P3r = RotationZ(P3r, angleConverted);
                P4r = RotationZ(P4r, angleConverted);

                //Back side rotation in z axis
                P5r = RotationZ(P5r, angleConverted);
                P6r = RotationZ(P6r, angleConverted);
                P7r = RotationZ(P7r, angleConverted);
                P8r = RotationZ(P8r, angleConverted);

                //Front side proyection
                P1p = Proyection(P1r, 3);
                P2p = Proyection(P2r, 3);
                P3p = Proyection(P3r, 3);
                P4p = Proyection(P4r, 3);

                //Back side proyection
                P5p = Proyection(P5r, 3);
                P6p = Proyection(P6r, 3);
                P7p = Proyection(P7r, 3);
                P8p = Proyection(P8r, 3);

                // Points to draw the square, front side
                squareA = new PointF((float)P1p[0], (float)P1p[1]);
                squareB = new PointF((float)P2p[0], (float)P2p[1]);
                squareC = new PointF((float)P3p[0], (float)P3p[1]);
                squareD = new PointF((float)P4p[0], (float)P4p[1]);

                // Points to draw the square, back side
                squareE = new PointF((float)P5p[0], (float)P5p[1]);
                squareF = new PointF((float)P6p[0], (float)P6p[1]);
                squareG = new PointF((float)P7p[0], (float)P7p[1]);
                squareH = new PointF((float)P8p[0], (float)P8p[1]);

                DrawFigure();
            }
        }

        public double[] RotationX(double[] array, double angle)
        {
            double[] pts = new double[3];
            // Rotation x axis matrix
            double[,] xRotation = new double[,]
            {
                {1, 0, 0},
                {0, Math.Cos(angle), -Math.Sin(angle)},
                {0, Math.Sin(angle), Math.Cos(angle)}
            };

            // Multiply the matrix with the given array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pts[i] += (float)xRotation[i, j] * array[j];
                }
            }

            return pts;
        }

        public double[] RotationY(double[] array, double angle)
        {
            double[] pts = new double[3];
            // Rotation y axis matrix
            double[,] yRotation = new double[,]
            {
                {Math.Cos(angle), 0, Math.Sin(angle)},
                {0, 1, 0},
                {-Math.Sin(angle), 0, Math.Cos(angle)}
            };

            // Multiply the matrix with the given array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pts[i] += (float)yRotation[i, j] * array[j];
                }
            }

            return pts;
        }

        public double[] RotationZ(double[] array, double angle)
        {
            double[] pts = new double[3];
            // Rotation y axis matrix
            double[,] zRotation = new double[,]
            {
                {Math.Cos(angle), -Math.Sin(angle), 0},
                {Math.Sin(angle), Math.Cos(angle), 0},
                {0, 0, 1}
            };

            // Multiply the matrix with the given array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pts[i] += (float)zRotation[i, j] * array[j];
                }
            }

            return pts;
        }

        public double[] Proyection(double[] array, int distance)
        {
            double[] pts = new double[2];
            
            // Obtain the new x using x = x / (distance - z)
            pts[0] = array[0] / (distance - array[2]);

            // Obtain the new y using y = y / (distance - z)
            pts[1] = array[1] / (distance - array[2]);
            return pts;
        }

        private void DrawFigure()
        {
            //Draw the square, front side
            Render(squareA, squareB);
            Render(squareB, squareC);
            Render(squareC, squareD);
            Render(squareD, squareA);

            //Draw the square, back side
            Render(squareE, squareF);
            Render(squareF, squareG);
            Render(squareG, squareH);
            Render(squareH, squareE);

            //Draw the square, conect front and back side
            Render(squareA, squareE);
            Render(squareB, squareF);
            Render(squareC, squareG);
            Render(squareD, squareH);
        }

        public void Render(PointF a, PointF b)
        {
            // Center the cube using the origen variable and adding the value of the trackbar to grow the cube
            PointF a2 = new PointF(origen.X + (a.X * trackBar1.Value), origen.Y - (a.Y * trackBar1.Value));
            PointF b2 = new PointF(origen.X + (b.X * trackBar1.Value), origen.Y - (b.Y * trackBar1.Value));

            // Draw line
            g.DrawLine(marcadorS, a2, b2);

            pictureBox1.Invalidate();
        }
    }
}
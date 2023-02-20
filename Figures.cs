using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perspectiva_3D
{

    public class Figures
    {
        public double[] P1 = new double[3];
        public double[] P2 = new double[3];
        public double[] P3 = new double[3];
        public double[] P4 = new double[3];
        public double[] P5 = new double[3];
        public double[] P6 = new double[3];
        public double[] P7 = new double[3];
        public double[] P8 = new double[3];

        public Figures(Vertex v1, Vertex v2, Vertex v3, Vertex v4, Vertex v5, Vertex v6, Vertex v7, Vertex v8)
        {
            P1[0] = v1.X;
            P1[1] = v1.Y;
            P1[2] = v1.Z;

            P2[0] = v2.X;
            P2[1] = v2.Y;
            P2[2] = v2.Z;

            P3[0] = v3.X;
            P3[1] = v3.Y;
            P3[2] = v3.Z;

            P4[0] = v4.X;
            P4[1] = v4.Y;
            P4[2] = v4.Z;

            P5[0] = v5.X;
            P5[1] = v5.Y;
            P5[2] = v5.Z;

            P6[0] = v6.X;
            P6[1] = v6.Y;
            P6[2] = v6.Z;

            P7[0] = v7.X;
            P7[1] = v7.Y;
            P7[2] = v7.Z;

            P8[0] = v8.X;
            P8[1] = v8.Y;
            P8[2] = v8.Z;
        }
    }
}

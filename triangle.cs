using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class triangle
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double y3 { get; set; }
        public double x0 { get; set; }
        public double y0 { get; set; }

        public triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public triangle(double x1, double x2, double x3, double y1, double y2, double y3, double x0, double y0)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.x0 = x0;
            this.y0 = y0;
        }

        ~triangle()
        {
            Console.WriteLine($"{x1}, {x2}, {x3}, {y1}, {y2}, {y3} has deleted");
        }

        public static double operator +(triangle triangle)
        {
            double AB = Math.Sqrt(((triangle.x1 - triangle.x2) * (triangle.x1 - triangle.x2)) + ((triangle.y1 - triangle.y2) * (triangle.y1 - triangle.y2)));
            double BC = Math.Sqrt(((triangle.x1 - triangle.x3) * (triangle.x1 - triangle.x3)) + ((triangle.y1 - triangle.y3) * (triangle.y1 - triangle.y3)));
            double AC = Math.Sqrt(((triangle.x2 - triangle.x3) * (triangle.x2 - triangle.x3)) + ((triangle.y2 - triangle.y3) * (triangle.y2 - triangle.y3)));
            double p = (AB + BC + AC) / 2;
            double res = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            return res;
        }
        public static bool operator !(triangle triangle)
        {
            double a = (triangle.x1 - triangle.x0) * (triangle.y2 - triangle.y1) - (triangle.x2 - triangle.x1) * (triangle.y1 - triangle.y0);
            double b = (triangle.x2 - triangle.x0) * (triangle.y3 - triangle.y2) - (triangle.x3 - triangle.x2) * (triangle.y2 - triangle.y0);
            double c = (triangle.x3 - triangle.x0) * (triangle.y1 - triangle.y3) - (triangle.x1 - triangle.x3) * (triangle.y3 - triangle.y0);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (triangle triangle1, triangle triangle2)
        {
            double AB1 = Math.Sqrt(((triangle1.x1 - triangle1.x2) * (triangle1.x1 - triangle1.x2)) + ((triangle1.y1 - triangle1.y2) * (triangle1.y1 - triangle1.y2)));
            double BC1 = Math.Sqrt(((triangle1.x1 - triangle1.x3) * (triangle1.x1 - triangle1.x3)) + ((triangle1.y1 - triangle1.y3) * (triangle1.y1 - triangle1.y3)));
            double AC1 = Math.Sqrt(((triangle1.x2 - triangle1.x3) * (triangle1.x2 - triangle1.x3)) + ((triangle1.y2 - triangle1.y3) * (triangle1.y2 - triangle1.y3)));
            double p1 = (AB1 + BC1 + AC1) / 2;
            double res1 = Math.Sqrt(p1 * (p1 - AB1) * (p1 - BC1) * (p1 - AC1));

            double AB2 = Math.Sqrt(((triangle2.x1 - triangle2.x2) * (triangle2.x1 - triangle2.x2)) + ((triangle2.y1 - triangle2.y2) * (triangle2.y1 - triangle2.y2)));
            double BC2 = Math.Sqrt(((triangle2.x1 - triangle2.x3) * (triangle2.x1 - triangle2.x3)) + ((triangle2.y1 - triangle2.y3) * (triangle2.y1 - triangle2.y3)));
            double AC2 = Math.Sqrt(((triangle2.x2 - triangle2.x3) * (triangle2.x2 - triangle2.x3)) + ((triangle2.y2 - triangle2.y3) * (triangle2.y2 - triangle2.y3)));
            double p2 = (AB2 + BC2 + AC2) / 2;
            double res2 = Math.Sqrt(p2 * (p2 - AB2) * (p2 - BC2) * (p2 - AC2));
            return res1 == res2;

        }

        public static bool operator !=(triangle triangle1, triangle triangle2)
        {
            double AB1 = Math.Sqrt(((triangle1.x1 - triangle1.x2) * (triangle1.x1 - triangle1.x2)) + ((triangle1.y1 - triangle1.y2) * (triangle1.y1 - triangle1.y2)));
            double BC1 = Math.Sqrt(((triangle1.x1 - triangle1.x3) * (triangle1.x1 - triangle1.x3)) + ((triangle1.y1 - triangle1.y3) * (triangle1.y1 - triangle1.y3)));
            double AC1 = Math.Sqrt(((triangle1.x2 - triangle1.x3) * (triangle1.x2 - triangle1.x3)) + ((triangle1.y2 - triangle1.y3) * (triangle1.y2 - triangle1.y3)));
            double p1 = (AB1 + BC1 + AC1) / 2;
            double res1 = Math.Sqrt(p1 * (p1 - AB1) * (p1 - BC1) * (p1 - AC1));

            double AB2 = Math.Sqrt(((triangle2.x1 - triangle2.x2) * (triangle2.x1 - triangle2.x2)) + ((triangle2.y1 - triangle2.y2) * (triangle2.y1 - triangle2.y2)));
            double BC2 = Math.Sqrt(((triangle2.x1 - triangle2.x3) * (triangle2.x1 - triangle2.x3)) + ((triangle2.y1 - triangle2.y3) * (triangle2.y1 - triangle2.y3)));
            double AC2 = Math.Sqrt(((triangle2.x2 - triangle2.x3) * (triangle2.x2 - triangle2.x3)) + ((triangle2.y2 - triangle2.y3) * (triangle2.y2 - triangle2.y3)));
            double p2 = (AB2 + BC2 + AC2) / 2;
            double res2 = Math.Sqrt(p2 * (p2 - AB2) * (p2 - BC2) * (p2 - AC2));
            return res1 == res2;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return "Координаты вершин треугольника" + "("+x1 +";"+ y1+")" + "(" + x2 + ";" + y2 + ")"+"(" + x3 + ";" + y3 + ")";
        }
    }
}

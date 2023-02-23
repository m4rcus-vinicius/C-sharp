using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeker.Draw
{
    public class Arc
    {
        private Vector3 center;
        private double radius;
        private double startAngle;
        private double endAngle;
        private double thickness;

        public Arc()
            : this(Vector3.Zero, 1.0, 0.0, 180.0)
        {

        }

        public Arc(Vector3 center, double radius, double start, double end)
        {
            this.Center = center;
            this.Radius = radius;
            this.StartAngle = start;
            this.EndAngle = end;
            this.Thickness = 0.0;

        }

        public double Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }


        public double EndAngle
        {
            get { return endAngle; }
            set { endAngle = value; }
        }


        public double StartAngle
        {
            get { return startAngle; }
            set { startAngle = value; }
        }


        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public Vector3 Center
        {
            get { return center; }
            set { center = value; }
        }

        public double Diameter
        {
            get
            {
                return this.Radius * 2;
            }
          
        }
         

    }
}

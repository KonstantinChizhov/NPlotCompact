namespace System.Drawing
{
    public struct PointF
    {
        private float x, y;

        public static readonly PointF Empty;

        public static implicit operator PointF(Point point)
        {
            return new PointF(point.X, point.Y);
        }

        public static PointF operator +(PointF pt, Size sz)
        {
            return new PointF(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static PointF operator +(PointF pt, SizeF sz)
        {
            return new PointF(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static bool operator ==(PointF left, PointF right)
        {
            return ((left.X == right.X) && (left.Y == right.Y));
        }

        public static bool operator !=(PointF left, PointF right)
        {
            return ((left.X != right.X) || (left.Y != right.Y));
        }

        public static PointF operator -(PointF pt, Size sz)
        {
            return new PointF(pt.X - sz.Width, pt.Y - sz.Height);
        }

        public static PointF operator -(PointF pt, SizeF sz)
        {
            return new PointF(pt.X - sz.Width, pt.Y - sz.Height);
        }


        public PointF(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsEmpty
        {
            get
            {
                return ((x == 0.0f) && (y == 0.0f));
            }
        }


        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PointF))
                return false;

            return (this == (PointF)obj);
        }

        public override int GetHashCode()
        {
            return (int)x ^ (int)y;
        }

        public override string ToString()
        {
            return String.Format("{{X={0}, Y={1}}}", x.ToString(),
                y.ToString());
        }

        public static PointF Add(PointF pt, Size sz)
        {
            return new PointF(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static PointF Add(PointF pt, SizeF sz)
        {
            return new PointF(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static PointF Subtract(PointF pt, Size sz)
        {
            return new PointF(pt.X - sz.Width, pt.Y - sz.Height);
        }

        public static PointF Subtract(PointF pt, SizeF sz)
        {
            return new PointF(pt.X - sz.Width, pt.Y - sz.Height);
        }
    }
}

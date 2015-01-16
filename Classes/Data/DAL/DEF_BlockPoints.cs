using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace DowntownBoiseAssociation.DAL.RecordDef
{
    public class ImagePoints
    {   
        private string _PointCategory;
        private int _PointIdentifier;        
        private Point[] _Points;
        private GraphicsPath _Path;

        public ImagePoints() {}

        public ImagePoints(string PointCategory, int PointIdentifier, Point[] Points, GraphicsPath Path)
        {
            _PointCategory = PointCategory;
            _PointIdentifier = PointIdentifier;
            _Points = Points;
            _Path = Path;
        }

        public string Category
        {
            get { return _PointCategory; }
            set { _PointCategory = value; }
        }

        public int Identifier
        {
            get { return _PointIdentifier; }
            set { _PointIdentifier = value; }
        }

        public Point[] Points
        {
            get { return _Points; }
            set { _Points = value; }
        }

        public GraphicsPath Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
    }
}

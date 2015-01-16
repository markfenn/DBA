using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace DowntownBoiseAssociation.BLL
{
    public class ImagePoints
    {
        public static List<DAL.RecordDef.ImagePoints> GetObjects(string Category)
        {
            List<DAL.RecordDef.ImagePoints> NewList = new List<DAL.RecordDef.ImagePoints>();
             
            DBADataContext BlockContext = new DBADataContext();

            var BlockQuery = (from BlockList in BlockContext.ImagePoints
                              where BlockList.PointCategory == Category
                              orderby BlockList.PointIdentifier
                              select BlockList.PointIdentifier).Distinct();

            List<Point> Points = new List<Point>();
            foreach (int BlockNo in BlockQuery)
            {
                var PointQuery = from PointList in BlockContext.ImagePoints
                                 where (PointList.PointIdentifier == BlockNo) && (PointList.PointCategory == Category)
                                 select PointList;
                Points.Clear();
                foreach (var PointItem in PointQuery)
                {
                    Point NewPoint = new Point(PointItem.x, PointItem.y);
                    Points.Add(NewPoint);
                }

                System.Drawing.Drawing2D.GraphicsPath NewPath = new System.Drawing.Drawing2D.GraphicsPath();
                NewPath.AddPolygon(Points.ToArray());

                NewList.Add(new DAL.RecordDef.ImagePoints(Category, BlockNo, Points.ToArray(), NewPath));
            }

            return NewList;
        }

        public static List<DAL.RecordDef.ImagePoints> GetObjectsByRange(int StartNumber, int EndNumber)
        {
            List<DAL.RecordDef.ImagePoints> NewList = new List<DAL.RecordDef.ImagePoints>();

            DBADataContext BlockContext = new DBADataContext();

            var BlockQuery = (from BlockList in BlockContext.ImagePoints
                              where (BlockList.PointIdentifier >= StartNumber) && (BlockList.PointIdentifier <= EndNumber)
                              orderby BlockList.PointIdentifier
                              select BlockList.PointIdentifier).Distinct();

            List<Point> Points = new List<Point>();
            foreach (int BlockNo in BlockQuery)
            {
                var PointQuery = from PointList in BlockContext.ImagePoints
                                 where (PointList.PointIdentifier == BlockNo) 
                                 select PointList;
               
                Points.Clear();
                foreach (var PointItem in PointQuery)
                {
                    Point NewPoint = new Point(PointItem.x, PointItem.y);
                    Points.Add(NewPoint);
                }

                System.Drawing.Drawing2D.GraphicsPath NewPath = new System.Drawing.Drawing2D.GraphicsPath();
                NewPath.AddPolygon(Points.ToArray());
                
                ImagePoint[] g = PointQuery.ToArray();

                NewList.Add(new DAL.RecordDef.ImagePoints(g[0].PointCategory, BlockNo, Points.ToArray(), NewPath));
            }

            return NewList;
        }


        public static List<string> GetCategories()
        {
            //List<string> NewList = new List<string>();

            DBADataContext CategoryContext = new DBADataContext();

            List<string> CatQuery = (from PointList in CategoryContext.ImagePoints
                            orderby PointList.PointCategory
                            select PointList.PointCategory).Distinct().ToList();

            return CatQuery;
        }
    }
}

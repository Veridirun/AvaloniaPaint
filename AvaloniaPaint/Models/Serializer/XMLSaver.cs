using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AvaloniaPaint.Models;

namespace AvaloniaPaint.Models.Serializer
{
    public class XMLSaver : IShapeSaver
    {
        public void Save(IEnumerable<PaintBaseFigure> figures, string path)
        {
            var xDocument = new XDocument();
            var figureTree=new XElement("FiguresTree");
            foreach (PaintBaseFigure figure in figures)
            {
                if(figure is PaintLine) {
                    var tmpfigure = figure as PaintLine;
                    if(tmpfigure != null) {
                        figureTree.Add(new XElement("Line",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("StartPoint", tmpfigure.StartPoint),
                            new XElement("EndPoint", tmpfigure.EndPoint)
                        ));
                    }
                }
                if (figure is PaintEllipse)
                {
                    var tmpfigure = figure as PaintEllipse;
                    if (tmpfigure != null)
                    {
                        figureTree.Add(new XElement("Ellipse",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("Height", tmpfigure.Height),
                            new XElement("Width", tmpfigure.Width),
                            new XElement("StartPoint", tmpfigure.StartPoint),
                            new XElement("FillColor", tmpfigure.FillColor)
                        ));
                    }
                }
                if (figure is PaintPath)
                {
                    var tmpfigure = figure as PaintPath;
                    if (tmpfigure != null)
                    {
                        figureTree.Add(new XElement("Path",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("Data", tmpfigure.Data),
                            new XElement("FillColor", tmpfigure.FillColor)
                        ));
                    }
                }
                if (figure is PaintPolygon)
                {
                    var tmpfigure = figure as PaintPolygon;
                    if (tmpfigure != null)
                    {
                        figureTree.Add(new XElement("Polygon",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("Points", tmpfigure.Points),
                            new XElement("FillColor", tmpfigure.FillColor)
                        ));
                    }
                }
                if (figure is PaintPolyline)
                {
                    var tmpfigure = figure as PaintPolyline;
                    if (tmpfigure != null)
                    {
                        figureTree.Add(new XElement("Polyline",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("Points", tmpfigure.Points)
                        ));
                    }
                }
                if (figure is PaintRectangle)
                {
                    var tmpfigure = figure as PaintRectangle;
                    if (tmpfigure != null)
                    {
                        figureTree.Add(new XElement("Rectangle",
                            new XElement("Name", tmpfigure.Name),
                            new XElement("StrokeThickness", tmpfigure.StrokeThickness),
                            new XElement("Stroke", tmpfigure.Stroke),
                            new XElement("Height", tmpfigure.Height),
                            new XElement("Width", tmpfigure.Width),
                            new XElement("StartPoint", tmpfigure.StartPoint),
                            new XElement("FillColor", tmpfigure.FillColor)
                        ));
                    }
                }
            }
            xDocument.Add(figureTree);
            xDocument.Save(path);
        }
    }
}

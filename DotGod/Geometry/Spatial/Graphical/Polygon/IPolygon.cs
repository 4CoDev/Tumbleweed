using DotGod.Geometry.Spatial.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Graphical.Polygon;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
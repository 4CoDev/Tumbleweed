using Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Concave.Polygon;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
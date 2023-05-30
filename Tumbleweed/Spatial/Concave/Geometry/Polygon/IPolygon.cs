using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Concave.Geometry.Polygon;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
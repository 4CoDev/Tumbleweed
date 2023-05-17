using Tumbleweed.Geometry.Spatial.Vertices;

namespace Tumbleweed.Geometry.Spatial.Concave.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
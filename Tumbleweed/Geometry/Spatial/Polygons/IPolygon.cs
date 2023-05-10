using Tumbleweed.Geometry.Spatial.Vertices;

namespace Tumbleweed.Geometry.Spatial.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}
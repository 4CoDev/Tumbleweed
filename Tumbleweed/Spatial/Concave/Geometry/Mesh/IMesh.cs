using Tumbleweed.Spatial.Concave.Geometry.Polygon;

namespace Tumbleweed.Spatial.Concave.Geometry.Mesh;

public interface IMesh
{
	IEnumerable<IPolygon> Polygons { get; }
}
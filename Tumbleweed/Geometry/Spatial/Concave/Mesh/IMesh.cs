using Tumbleweed.Geometry.Spatial.Concave.Polygon;

namespace Tumbleweed.Geometry.Spatial.Concave.Mesh;

public interface IMesh
{
	IEnumerable<IPolygon> Polygons { get; }
}
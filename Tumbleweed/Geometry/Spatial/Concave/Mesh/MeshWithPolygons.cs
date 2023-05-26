using Tumbleweed.Geometry.Spatial.Concave.Polygon;

namespace Tumbleweed.Geometry.Spatial.Concave.Mesh;

public sealed class MeshWithPolygons : IMesh
{
	public MeshWithPolygons(IEnumerable<IPolygon> polygons) =>
		Polygons = polygons;

	public IEnumerable<IPolygon> Polygons { get; }
}
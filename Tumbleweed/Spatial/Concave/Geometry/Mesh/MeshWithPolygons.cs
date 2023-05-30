using Tumbleweed.Spatial.Concave.Geometry.Polygon;

namespace Tumbleweed.Spatial.Concave.Geometry.Mesh;

public sealed class MeshWithPolygons : IMesh
{
	public MeshWithPolygons(IEnumerable<IPolygon> polygons) =>
		Polygons = polygons;

	public IEnumerable<IPolygon> Polygons { get; }
}
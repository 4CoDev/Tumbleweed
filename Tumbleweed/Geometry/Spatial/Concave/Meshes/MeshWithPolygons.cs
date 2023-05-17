using Tumbleweed.Geometry.Spatial.Concave.Polygons;

namespace Tumbleweed.Geometry.Spatial.Concave.Meshes;

public sealed class MeshWithPolygons : IMesh
{
	public MeshWithPolygons(IEnumerable<IPolygon> polygons) =>
		Polygons = polygons;

	public IEnumerable<IPolygon> Polygons { get; }
}
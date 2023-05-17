using Tumbleweed.Geometry.Spatial.Concave.Polygons;

namespace Tumbleweed.Geometry.Spatial.Concave.Meshes;

public interface IMesh
{
	IEnumerable<IPolygon> Polygons { get; }
}
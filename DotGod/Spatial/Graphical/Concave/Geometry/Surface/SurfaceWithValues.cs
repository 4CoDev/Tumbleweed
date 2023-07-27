using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class SurfaceWithValues : ISurface
{
	public SurfaceWithValues
	(
		IEnumerable<IPolygon> polygons,
		Any<Material> material
	)
	{
		Polygons = polygons;
		Material = material;
	}
	
	public IEnumerable<IPolygon> Polygons { get; }
	
	public Any<Material> Material { get; }
}
using DotGod.Geometry.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces;

public sealed class SurfaceWithValues : ISurface
{
	public SurfaceWithValues
	(
		IEnumerable<IPolygon> polygons,
		IScalar<Material> material
	)
	{
		Polygons = polygons;
		Material = material;
	}
	
	public IEnumerable<IPolygon> Polygons { get; }
	
	public IScalar<Material> Material { get; }
}
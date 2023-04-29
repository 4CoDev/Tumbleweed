using DotGod.Geometrics.Graphical.Polygons;
using Godot;
using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces;

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
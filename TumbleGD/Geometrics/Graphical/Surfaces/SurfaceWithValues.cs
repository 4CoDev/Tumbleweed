using Godot;
using TumbleGD.Geometrics.Graphical.Polygons;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

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
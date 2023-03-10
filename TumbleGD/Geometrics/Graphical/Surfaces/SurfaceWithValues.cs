using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public sealed class SurfaceWithValues : ISurface
{
	public SurfaceWithValues
	(
		IEnumerable<IEnumerable<IVertex>> polygons,
		IScalar<Material> material
	)
	{
		Polygons = polygons;
		Material = material;
	}
	
	public IEnumerable<IEnumerable<IVertex>> Polygons { get; }
	
	public IScalar<Material> Material { get; }
}
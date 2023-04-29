using DotGod.Geometrics.Graphical.Surfaces.Numeric.FromArrayMeshes.ToSystem;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;

public sealed class SurfacesFromMesh : EnumerableEnvelope<ISurface>
{
	public SurfacesFromMesh(IScalar<ArrayMesh> mesh) : base
	(
		new EnumerableOfFunction<ISurface>(
			() => Function(mesh))
	)
	{
	}

	private static IEnumerable<ISurface> Function
	(
		IScalar<ArrayMesh> mesh
	)
	{
		Int32 count = new SurfaceCountOfMesh(mesh).Value;
		for (Int32 i = 0; i < count; i++)
			yield return new SurfaceWithIndex(mesh, i);
	}
}
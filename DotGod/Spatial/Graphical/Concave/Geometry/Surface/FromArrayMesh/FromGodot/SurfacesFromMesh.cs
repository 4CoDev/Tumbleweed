using DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh.ToSystem;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;

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
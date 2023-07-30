using DotGod.Spatial.Graphical.Concave.Geometry.Surface.Number.FromArrayMesh.ToSystem;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;

public sealed class SurfacesFromMesh : Tumbleweed.Enumerable.Envelope<ISurface>
{
	public SurfacesFromMesh(Any<ArrayMesh> mesh) : base
	(
		new Result<ISurface>(
			() => Function(mesh))
	)
	{
	}

	private static IEnumerable<ISurface> Function
	(
		Any<ArrayMesh> mesh
	)
	{
		Int32 count = new SurfaceCountOfMesh(mesh).Value;
		for (Int32 i = 0; i < count; i++)
			yield return new SurfaceWithIndex(mesh, i);
	}
}
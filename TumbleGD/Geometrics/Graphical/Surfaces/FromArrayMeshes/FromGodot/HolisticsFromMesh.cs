using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.Numeric.FromArrayMeshes.ToSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;

public sealed class HolisticsFromMesh : EnumerableEnvelope<ISurface>
{
	public HolisticsFromMesh(IScalar<ArrayMesh> mesh) : base
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
			yield return new HolisticWithIndex(mesh, i);
	}
}
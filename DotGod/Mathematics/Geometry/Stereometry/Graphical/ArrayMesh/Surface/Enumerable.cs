using DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index;
using DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable(Any<Godot.ArrayMesh> mesh) : base
	(
		new Result<Any>(
			() => Function(mesh))
	)
	{
	}

	private static IEnumerable<Any> Function
	(
		Any<Godot.ArrayMesh> mesh
	)
	{
		Int32 count = new Count.System(mesh).Value;
		for (Int32 i = 0; i < count; i++)
			yield return new One(mesh, i);
	}
}
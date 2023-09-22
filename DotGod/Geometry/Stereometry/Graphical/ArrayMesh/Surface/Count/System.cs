using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Geometry.Stereometry.Graphical.ArrayMesh.Surface.
	Count;

public sealed class System : Envelope<Int32>
{
	public System(Any<Godot.ArrayMesh> mesh) : base
	(
		new Actual<Int32>(
			() => mesh.Value.GetSurfaceCount())
	)
	{
	}
}
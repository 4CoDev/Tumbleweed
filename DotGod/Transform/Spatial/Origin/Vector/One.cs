using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Transform.Spatial.Origin.Vector;

public sealed class One : Envelope<Vector3>
{
	public One(Any<Transform3D> transform) : base
	(
		new Actual<Vector3>(
			() => transform.Value.Origin)
	)
	{
	}
}
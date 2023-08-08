using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Transform.Spatial.Number.Binary.Spatial.OfGodot;

public sealed class OriginOfTransform : Envelope<Vector3>
{
	public OriginOfTransform(Any<Transform3D> transform) : base
	(
		new Actual<Vector3>(
			() => transform.Value.Origin)
	)
	{
	}
}
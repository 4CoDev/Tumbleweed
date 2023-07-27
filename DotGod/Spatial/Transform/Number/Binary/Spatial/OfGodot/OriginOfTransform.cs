using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial.Transform.Number.Binary.Spatial.OfGodot;

public sealed class OriginOfTransform : Envelope<Vector3>
{
	public OriginOfTransform(Any<Transform3D> transform) : base
	(
		new Tumbleweed.Scalar.Function.Result<Vector3>(
			() => transform.Value.Origin)
	)
	{
	}
}
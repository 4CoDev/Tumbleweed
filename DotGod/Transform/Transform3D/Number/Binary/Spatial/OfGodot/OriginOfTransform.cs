using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Transform.Transform3D.Number.Binary.Spatial.OfGodot;

public sealed class OriginOfTransform : ScalarEnvelope<Vector3>
{
	public OriginOfTransform(IScalar<Godot.Transform3D> transform) : base
	(
		new ResultOfFunction<Vector3>(
			() => transform.Value.Origin)
	)
	{
	}
}
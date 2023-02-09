using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Transforms.Transforms3D.Numerics.Binaries.Spatials.OfGodot;

public sealed class OriginOfTransform : ScalarEnvelope<Vector3>
{
	public OriginOfTransform(IScalar<Transform3D> transform) : base
	(
		new ScalarOfDelegate<Vector3>(
			() => transform.Value().Origin)
	)
	{
	}
}
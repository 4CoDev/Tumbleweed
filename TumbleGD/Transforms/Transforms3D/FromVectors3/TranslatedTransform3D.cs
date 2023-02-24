using Godot;
using TumbleGD.Numerics.Decimals.Spatials.ToGodot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Transforms.Transforms3D.FromVectors3;

public sealed class TranslatedTransform3D : ScalarEnvelope<Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Transform3D> transform,
		IScalar<Vector3> translation
	) : base
	(
		new ScalarOfDelegate<Transform3D>(
			() => transform.Value.Translated(translation.Value))
	)
	{
	}
}
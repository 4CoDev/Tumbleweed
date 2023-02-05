using Godot;
using TumbleGD.Numerics.Decimals.Spatials.ToGodot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Transforms.Transforms3D.FromSpatials;

public sealed class TranslatedTransform3D : ScalarEnvelope<Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Transform3D> transform,
		ISpatial<IDecimal> translation
	) : base
	(
		new FromVectors3.TranslatedTransform3D(
			transform,
			new Vector3FromSpatial(translation))
	)
	{
	}
}
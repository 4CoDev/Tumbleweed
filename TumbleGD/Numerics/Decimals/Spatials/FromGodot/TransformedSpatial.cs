using Godot;
using TumbleGD.Transforms.Transforms3D.FromSpatials;
using TumbleGD.Transforms.Transforms3D.Numerics.Binaries.Spatials.OfGodot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Spatials.FromGodot;

public sealed class TransformedSpatial : SpatialEnvelope<IFractional>
{
	public TransformedSpatial
	(
		ISpatial<IFractional> spatial,
		IScalar<Transform3D> transform
	) : base
	(
		new SpatialFromVector3(
			new OriginOfTransform(
				new TranslatedTransform3D(transform, spatial)))
	)
	{
	}
}
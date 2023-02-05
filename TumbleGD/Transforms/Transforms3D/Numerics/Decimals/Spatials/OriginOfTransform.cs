using Godot;
using TumbleGD.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Transforms.Transforms3D.Numerics.Decimals.Spatials;

public sealed class OriginOfTransform : SpatialEnvelope<IDecimal>
{
	public OriginOfTransform(IScalar<Transform3D> transform) : base
	(
		new SpatialFromVector3(
			new Binaries.Spatials.OfGodot.OriginOfTransform(transform))
	)
	{
	}
}
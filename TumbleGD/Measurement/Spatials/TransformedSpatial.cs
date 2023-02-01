using Godot;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace TumbleGD.Measurement.Spatials;

public sealed class TransformedSpatial : SpatialEnvelope<float>
{
	public TransformedSpatial
	(
		ISpatial<float> spatial,
		IScalar<Transform3D> transform
	) : base
	(
		new SpatialFromScalar<float>(
			new Scalar.TransformedSpatial(
				spatial, transform))
	)
	{
	}
}
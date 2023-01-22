using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials;

public sealed class Transformed : SpatialEnvelope<float>
{
	public Transformed
	(
		ISpatial<float> spatial,
		IScalar<Transform3D> transform
	) : base
	(
		new SpatialFromScalar<float>(
			new Scalar.Transformed(spatial, transform))
	)
	{
	}
}
using Godot;

namespace Tumbleweed.Measurement.Spatials;

public sealed class SpatialFromVector3 : SpatialEnvelope<float>
{
	public SpatialFromVector3(Vector3 vector3) : base
	(
		new SpatialFromScalar<float>(
			new Scalar.SpatialFromVector3(vector3))
	)
	{
	}
}
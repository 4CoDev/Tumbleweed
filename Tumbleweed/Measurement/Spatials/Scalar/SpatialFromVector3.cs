using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials.Scalar;

public sealed class SpatialFromVector3 : IScalar<ISpatial<float>>
{
	
	public SpatialFromVector3(Vector3 vector3) : this
	(
		new ScalarOfValue<Vector3>(vector3)
	)
	{
	}
	
	public SpatialFromVector3(IScalar<Vector3> vector3)
	{
		this.vector3 = vector3;
	}

	public ISpatial<float> Value()
	{
		return new Spatial<float>(
			(dynamic) vector3.Value().x,
			(dynamic) vector3.Value().y,
			(dynamic) vector3.Value().z);
	}

	private readonly IScalar<Vector3> vector3;
}
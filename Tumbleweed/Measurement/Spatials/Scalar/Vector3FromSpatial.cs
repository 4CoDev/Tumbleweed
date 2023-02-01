using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials.Scalar;

public sealed class Vector3FromSpatial : IScalar<Vector3>
{
	public Vector3FromSpatial(ISpatial<float> spatial)
	{
		this.spatial = spatial;
	}
	
	public Vector3 Value()
	{
		return new Vector3(spatial.X, spatial.Y, spatial.Z);
	}
	
	private readonly ISpatial<float> spatial;
}
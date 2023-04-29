using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Numerics.Decimals.Spatials.FromGodot;

public sealed class SpatialFromVector3 : SpatialEnvelope<IFractional>
{
	public SpatialFromVector3(Vector3 vector) : this
	(
		new ScalarValue<Vector3>(vector)
	)
	{
	}

	public SpatialFromVector3(IScalar<Vector3> vector) : base
	(
		new SpatialWithCoordinates<IFractional>(
			new FractionalFromSingle(vector.Value.X),
			new FractionalFromSingle(vector.Value.Y),
			new FractionalFromSingle(vector.Value.Z))
	)
	{
	}
}
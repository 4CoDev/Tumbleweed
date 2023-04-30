using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Numerics.Decimals.Spatials.FromGodot;

public sealed class SpatialFromVector3 : SpatialEnvelope<IReal>
{
	public SpatialFromVector3(Vector3 vector) : this
	(
		new ScalarValue<Vector3>(vector)
	)
	{
	}

	public SpatialFromVector3(IScalar<Vector3> vector) : base
	(
		new SpatialWithCoordinates<IReal>(
			new RealFromSingle(vector.Value.X),
			new RealFromSingle(vector.Value.Y),
			new RealFromSingle(vector.Value.Z))
	)
	{
	}
}
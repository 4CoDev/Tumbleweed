using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Decimals.FromSystem;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Spatials.FromGodot;

public sealed class SpatialFromVector3 : SpatialEnvelope<IDecimal>
{
	public SpatialFromVector3(Vector3 vector) : this
	(
		new ScalarOfValue<Vector3>(vector)
	)
	{
	}

	public SpatialFromVector3(IScalar<Vector3> vector) : base
	(
		new SpatialWithValues<IDecimal>(
			new DecimalFromSingle(vector.Value().X),
			new DecimalFromSingle(vector.Value().Y),
			new DecimalFromSingle(vector.Value().Z))
	)
	{
	}
}
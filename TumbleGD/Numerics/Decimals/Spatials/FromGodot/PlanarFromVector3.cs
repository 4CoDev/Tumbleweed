using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Decimals.FromSystem;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Spatials.FromGodot;

public sealed class PlanarFromVector3 : SpatialEnvelope<IDecimal>
{
	public PlanarFromVector3(Vector3 vector) : this
	(
		new ScalarOfValue<Vector3>(vector)
	)
	{
	}

	public PlanarFromVector3(IScalar<Vector3> vector) : base
	(
		new SpatialWithValues<IDecimal>(
			new DecimalFromSingle(vector.Value().x),
			new DecimalFromSingle(vector.Value().y),
			new DecimalFromSingle(vector.Value().z))
	)
	{
	}
}
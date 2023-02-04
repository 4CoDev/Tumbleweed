using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Decimals.FromSystem;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Planars.FromGodot;

public sealed class PlanarFromVector2 : PlanarEnvelope<IDecimal>
{
	public PlanarFromVector2(Vector2 vector) : this
	(
		new ScalarOfValue<Vector2>(vector)
	)
	{
	}

	public PlanarFromVector2(IScalar<Vector2> vector) : base
	(
		new PlanarWithValues<IDecimal>(
			new DecimalFromSingle(vector.Value().x),
			new DecimalFromSingle(vector.Value().y))
	)
	{
	}
}
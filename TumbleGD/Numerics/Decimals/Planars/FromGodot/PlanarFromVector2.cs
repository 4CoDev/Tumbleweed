using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Planars.FromGodot;

public sealed class PlanarFromVector2 : PlanarEnvelope<IFractional>
{
	public PlanarFromVector2(Vector2 vector) : this
	(
		new ScalarValue<Vector2>(vector)
	)
	{
	}

	public PlanarFromVector2(IScalar<Vector2> vector) : base
	(
		new PlanarWithValues<IFractional>(
			new FractionalFromSingle(vector.Value.X),
			new FractionalFromSingle(vector.Value.Y))
	)
	{
	}
}
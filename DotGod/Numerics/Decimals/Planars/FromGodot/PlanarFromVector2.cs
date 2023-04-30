using Godot;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Scalars;

namespace DotGod.Numerics.Decimals.Planars.FromGodot;

public sealed class PlanarFromVector2 : PlanarEnvelope<IReal>
{
	public PlanarFromVector2(Vector2 vector) : this
	(
		new ScalarValue<Vector2>(vector)
	)
	{
	}

	public PlanarFromVector2(IScalar<Vector2> vector) : base
	(
		new PlanarWithValues<IReal>(
			new RealFromSingle(vector.Value.X),
			new RealFromSingle(vector.Value.Y))
	)
	{
	}
}
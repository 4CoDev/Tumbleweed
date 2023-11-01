using Tumbleweed.Mathematics.Number.Real;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Planar.Godot.From.Tumbleweed;

public sealed class One : Property::Envelope<Godot::Vector2>
{
	public One(global::Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Any> point) : base
	(
		new Property::Function.Result.Actual<Godot::Vector2>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector2 Result
	(global::Tumbleweed.Mathematics.Vector.Planar.Generic.Any<Any> point
	) =>
	(
		new Godot::Vector2(
			new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.X).Value,
			new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Y).Value)
	);
}
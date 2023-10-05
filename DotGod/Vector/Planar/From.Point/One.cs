using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Vector.Planar.From.Point;

public sealed class One : Immutable::Envelope<Godot::Vector2>
{
	public One(Any<Any> point) : base
	(
		new Immutable::Function.Result.Actual<Godot::Vector2>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector2 Result
	(
		Any<Any> point
	) =>
	(
		new Godot::Vector2(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.X).Value,
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Y).Value)
	);
}
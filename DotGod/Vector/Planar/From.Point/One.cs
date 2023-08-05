using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = Tumbleweed.Point.Planar;
using Real = Tumbleweed.Number.Real;
using SystemRealFromTumbleweed =
	Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

namespace DotGod.Vector.Planar.From.Point;

public sealed class One : Immutable::Envelope<Godot::Vector2>
{
	public One(Point::Any<Real::Any> point) : base
	(
		new Immutable::Function.Result.Actual<Godot::Vector2>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector2 Result
	(
		Point::Any<Real::Any> point
	) =>
	(
		new Godot::Vector2(
			new SystemRealFromTumbleweed::One(point.X).Value,
			new SystemRealFromTumbleweed::One(point.Y).Value)
	);
}
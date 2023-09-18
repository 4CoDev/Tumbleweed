using Tumbleweed.Point.Spatial.Generic;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using SystemRealFromTumbleweed =
	Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

namespace DotGod.Vector.Spatial.From.Point;

public sealed class One : Immutable::Envelope<Godot::Vector3>
{
	public One(Any<Real::Any> point) : base
	(
		new Immutable::Function.Result.Actual<Godot::Vector3>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector3 Result
	(
		Any<Real::Any> point
	) =>
	(
		new Godot::Vector3(
			new SystemRealFromTumbleweed::One(point.X).Value,
			new SystemRealFromTumbleweed::One(point.Y).Value,
			new SystemRealFromTumbleweed::One(point.Z).Value)
	);
}
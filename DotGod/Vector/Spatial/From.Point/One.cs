using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Immutable = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace DotGod.Vector.Spatial.From.Point;

public sealed class One : Immutable::Envelope<Godot::Vector3>
{
	public One(Any<Any> point) : base
	(
		new Immutable::Function.Result.Actual<Godot::Vector3>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector3 Result
	(
		Any<Any> point
	) =>
	(
		new Godot::Vector3(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.X).Value,
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Y).Value,
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Z).Value)
	);
}
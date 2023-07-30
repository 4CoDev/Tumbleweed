using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Point.Planar;
using Tumbleweed.Point.Planar.With;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Planar.Vector.Point;

public sealed class PointFromVector2 : Tumbleweed.Point.Planar.Envelope<Any>
{
	public PointFromVector2(Vector2 vector) : this
	(
		new Value<Vector2>(vector)
	)
	{
	}

	public PointFromVector2(Tumbleweed.Scalar.Immutable.Any<Vector2> vector) : base
	(
		new Coordinates<Any>(
			new One(vector.Value.X),
			new One(vector.Value.Y))
	)
	{
	}
}
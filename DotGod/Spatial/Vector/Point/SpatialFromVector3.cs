using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.With.Coordinates;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Vector.Point;

public sealed class PointFromVector3 : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public PointFromVector3(Vector3 vector) : this
	(
		new Value<Vector3>(vector)
	)
	{
	}

	public PointFromVector3(Tumbleweed.Scalar.Immutable.Any<Vector3> vector) : base
	(
		new Unique<Any>(
			new One(vector.Value.X),
			new One(vector.Value.Y),
			new One(vector.Value.Z))
	)
	{
	}
}
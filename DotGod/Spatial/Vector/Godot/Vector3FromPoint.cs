using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Vector.Godot;

public sealed class Vector3FromPoint : Tumbleweed.Scalar.Immutable.Envelope<Vector3>
{
	public Vector3FromPoint(Tumbleweed.Point.Spatial.Any<Any> point) : base
	(
		new Actual<Vector3>(
			() => Result(point))
	)
	{
	}

	private static Vector3 Result(Tumbleweed.Point.Spatial.Any<Any> point) =>
	(
		new Vector3(
			new One(point.X).Value,
			new One(point.Y).Value,
			new One(point.Z).Value)
	);
}
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;
using Tumbleweed.Point.Planar;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Planar.Vector;

public sealed class Vector2FromPlanar : Tumbleweed.Scalar.Envelope<Vector2>
{
	public Vector2FromPlanar(Tumbleweed.Point.Planar.Any<Any> point) : base
	(
		new Tumbleweed.Scalar.Function.Result<Vector2>(
			() => Result(point))
	)
	{
	}

	private static Vector2 Result(Tumbleweed.Point.Planar.Any<Any> point)
	{
		return new Vector2(
			new One(point.X).Value,
			new One(point.Y).Value);
	}
}
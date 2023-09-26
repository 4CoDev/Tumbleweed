using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Z.Actual;

public sealed class One<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Actual<T>(
			() => point.Z)
	)
	{
	}
}
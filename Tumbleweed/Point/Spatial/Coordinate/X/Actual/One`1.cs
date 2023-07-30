using Tumbleweed.Scalar.Immutable.Function.Result;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate.X.Actual;

public sealed class One<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Actual<T>(
			() => point.X)
	)
	{
	}
}
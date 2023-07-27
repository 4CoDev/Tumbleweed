using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate.X.Actual;

public sealed class One<T> : Scalar::Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Scalar::Function.Result<T>(
			() => point.X)
	)
	{
	}
}
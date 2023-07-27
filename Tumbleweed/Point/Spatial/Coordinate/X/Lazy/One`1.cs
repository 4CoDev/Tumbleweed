using Tumbleweed.Point.Spatial.Coordinate.X.Actual;
using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial.Coordinate.X.Lazy;

public sealed class One<T> : Scalar::Envelope<T>
{
	public One(Point::Any<T> point) : base
	(
		new Scalar::Lazy.OfValue<T>(
			new Actual.One<T>(point))
	)
	{
	}
}
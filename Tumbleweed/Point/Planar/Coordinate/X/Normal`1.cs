using Scalar = Tumbleweed.Scalar;
using Point = Tumbleweed.Point.Planar;

namespace Tumbleweed.Point.Planar.Coordinate.X;

public sealed class Normal<T> : Scalar::Envelope<T>
{
	public Normal(Point::Any<T> point) : base
	(
		new Scalar::Function.Result<T>(
			() => point.X)
	)
	{
	}
}
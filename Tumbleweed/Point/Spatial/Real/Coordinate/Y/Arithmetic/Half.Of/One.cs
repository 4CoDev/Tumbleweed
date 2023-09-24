using Tumbleweed.Mathematics.Number.Real;
using Real = Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Arithmetic.Half.Of;

public sealed class One : Envelope
{
	public One
	(
		Point::Generic.Any<Any> point
	) : base
	(
		new Mathematics.Arithmetic.Real.Half.Of.One(
			new Point::Real.Coordinate.Y.Value.One(point))
	)
	{
	}
}
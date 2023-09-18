using Real = Tumbleweed.Number.Real;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Y.Arithmetic.Half.Of;

public sealed class One : Real::Envelope
{
	public One
	(
		Point::Generic.Any<Real::Any> point
	) : base
	(
		new Real::Arithmetic.Half.Of.One(
			new Point::Real.Coordinate.Y.Value.One(point))
	)
	{
	}
}
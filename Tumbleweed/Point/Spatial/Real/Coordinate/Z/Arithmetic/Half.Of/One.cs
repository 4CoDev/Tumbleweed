using Tumbleweed.Mathematics.Number.Real;
using Real = Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial.Real.Coordinate.Z.Arithmetic.Half.Of;

public sealed class One : Envelope
{
	public One
	(
		Point::Generic.Any<Any> point
	) : base
	(
		new Mathematics.Arithmetic.Real.Half.Of.One(
			new Point::Real.Coordinate.Z.Value.One(point))
	)
	{
	}
}
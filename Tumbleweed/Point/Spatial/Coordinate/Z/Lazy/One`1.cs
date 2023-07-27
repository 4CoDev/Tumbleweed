using Tumbleweed.Point.Spatial.Coordinate.Z.Actual;
using Tumbleweed.Scalar.Lazy;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Coordinate.Z.Lazy;

public sealed class One<T> : Scalar::Envelope<T>
{
	public One(Any<T> point) : base
	(
		new OfValue<T>(
			new Actual.One<T>(point))
	)
	{
	}
}
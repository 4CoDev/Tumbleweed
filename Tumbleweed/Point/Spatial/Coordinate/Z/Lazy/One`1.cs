using Immutable = Tumbleweed.Scalar.Immutable;
using Coordinate = Tumbleweed.Point.Spatial.Coordinate;

namespace Tumbleweed.Point.Spatial.Coordinate.Z.Lazy;

public sealed class One<T> : Immutable::Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Immutable::Lazy<T>(
			new Coordinate::Z.Actual.One<T>(point))
	)
	{
	}
}
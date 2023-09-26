using Immutable = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Y.Lazy;

public sealed class One<T> : Immutable::Envelope<T>
{
	public One(Any<T> point) : base
	(
		new Immutable::Lazy<T>(
			new Actual.One<T>(point))
	)
	{
	}
}
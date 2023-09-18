using Immutable = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Point.Spatial.Generic.Coordinate.Z.Lazy;

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
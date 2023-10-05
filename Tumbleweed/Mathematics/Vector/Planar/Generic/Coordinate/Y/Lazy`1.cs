namespace Tumbleweed.Mathematics.Vector.Planar.Generic.Coordinate.Y;

public sealed class Lazy<T> : Tumbleweed.Scalar.Immutable.Envelope<T>
{
	public Lazy(Any<T> point) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new Normal<T>(point))
	)
	{
	}
}
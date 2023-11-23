using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate;

public sealed class Enumerable<T> : Enumerable::Envelope<T>
{
	public Enumerable(Any<T> point) : base
	(
		new Enumerable::From.Array<T>(
			point.X,
			point.Y,
			point.Z)
	)
	{
	}
}
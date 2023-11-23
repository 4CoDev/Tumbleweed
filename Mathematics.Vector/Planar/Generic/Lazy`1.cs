using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Planar.Generic;

public sealed class Lazy<T> : Envelope<T>
{
	public Lazy(Any<T> point) : base
	(
		new Unique<T>(
			new Coordinate.X.Lazy<T>(point),
			new Coordinate.Y.Lazy<T>(point))
	)
	{
	}
}
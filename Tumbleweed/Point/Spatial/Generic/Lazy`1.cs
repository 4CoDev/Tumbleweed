using Tumbleweed.Point.Spatial.Generic.Coordinate.X.Lazy;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Point.Spatial.Generic;

public sealed class Lazy<T> : Envelope<T>
{
	public Lazy(Any<T> point) : base
	(
		new Unique<T>(
			new One<T>(point),
			new Coordinate.Y.Lazy.One<T>(point),
			new Coordinate.Z.Lazy.One<T>(point))
	)
	{
	}
}
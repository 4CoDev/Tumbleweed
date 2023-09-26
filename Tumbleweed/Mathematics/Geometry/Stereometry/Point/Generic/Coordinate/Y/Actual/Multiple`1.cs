using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.Y.Actual;

public sealed class Multiple<T> : Tumbleweed.Enumerable.Envelope<T>
{
	public Multiple(IEnumerable<Any<T>> spatials) : base
	(
		new Selected<Any<T>, T>(
			spatials,
			spatial => spatial.Y)
	)
	{
	}
}
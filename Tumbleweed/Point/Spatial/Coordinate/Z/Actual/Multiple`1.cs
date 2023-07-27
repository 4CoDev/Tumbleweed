using Tumbleweed.Enumerable;

namespace Tumbleweed.Point.Spatial.Coordinate.Z.Actual;

public sealed class Multiple<T> : Tumbleweed.Enumerable.Envelope<T>
{
	public Multiple(IEnumerable<Any<T>> spatials) : base
	(
		new Selected<Any<T>, T>(
			spatials,
			spatial => spatial.Z)
	)
	{
	}
}
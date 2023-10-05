using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Z.Actual;

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
using Tumbleweed._Enumerable;

namespace Tumbleweed.Point.Spatial.Coordinate;

public sealed class YOfPoints<T> : EnumerableEnvelope<T>
{
	public YOfPoints(IEnumerable<IPoint<T>> spatials) : base
	(
		new SelectedByExpression<IPoint<T>, T>(
			spatials,
			spatial => spatial.Y)
	)
	{
	}
}
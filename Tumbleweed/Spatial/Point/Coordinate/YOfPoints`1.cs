using Tumbleweed._Enumerable;

namespace Tumbleweed.Spatial.Point.Coordinate;

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
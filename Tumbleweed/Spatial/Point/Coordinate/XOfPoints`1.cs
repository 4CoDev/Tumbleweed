using Tumbleweed._Enumerable;

namespace Tumbleweed.Spatial.Point.Coordinate;

public sealed class XOfPoints<T> : EnumerableEnvelope<T>
{
	public XOfPoints(IEnumerable<IPoint<T>> spatials) : base
	(
		new SelectedByExpression<IPoint<T>, T>(
			spatials,
			spatial => spatial.X)
	)
	{
	}
}
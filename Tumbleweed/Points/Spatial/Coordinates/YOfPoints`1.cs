using Tumbleweed.Enumerables;

namespace Tumbleweed.Points.Spatial.Coordinates;

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
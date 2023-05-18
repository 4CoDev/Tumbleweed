using Tumbleweed.Enumerables;

namespace Tumbleweed.Points.Spatial.Coordinates;

public sealed class ZOfPoints<T> : EnumerableEnvelope<T>
{
	public ZOfPoints(IEnumerable<IPoint<T>> spatials) : base
	(
		new SelectedByExpression<IPoint<T>, T>(
			spatials,
			spatial => spatial.Z)
	)
	{
	}
}
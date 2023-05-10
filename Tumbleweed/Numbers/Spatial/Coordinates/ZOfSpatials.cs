using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Spatial.Coordinates;

public sealed class ZOfSpatials<T> : EnumerableEnvelope<T>
{
	public ZOfSpatials(IEnumerable<ISpatial<T>> spatials) : base
	(
		new SelectedByExpression<ISpatial<T>, T>(
			spatials,
			spatial => spatial.Z)
	)
	{
	}
}
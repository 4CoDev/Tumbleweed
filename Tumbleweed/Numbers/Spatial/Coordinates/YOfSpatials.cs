using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Spatial.Coordinates;

public sealed class YOfSpatials<T> : EnumerableEnvelope<T>
{
	public YOfSpatials(IEnumerable<ISpatial<T>> spatials) : base
	(
		new SelectedByExpression<ISpatial<T>, T>(
			spatials,
			spatial => spatial.Y)
	)
	{
	}
}
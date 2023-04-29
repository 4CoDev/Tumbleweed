using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Spatial.Coordinates;

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
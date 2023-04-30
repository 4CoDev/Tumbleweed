using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Spatial.Coordinates;

public sealed class XOfSpatials<T> : EnumerableEnvelope<T>
{
	public XOfSpatials(IEnumerable<ISpatial<T>> spatials) : base
	(
		new SelectedByExpression<ISpatial<T>, T>(
			spatials,
			spatial => spatial.X)
	)
	{
	}
}
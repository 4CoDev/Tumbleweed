using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Spatial.Coordinates;

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
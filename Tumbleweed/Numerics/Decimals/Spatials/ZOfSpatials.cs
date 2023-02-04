using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatials;

public sealed class ZOfSpatials : EnumerableEnvelope<IDecimal>
{
	public ZOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : base
	(
		new SelectedByExpression<ISpatial<IDecimal>, IDecimal>(
			spatials,
			spatial => spatial.Z)
	)
	{
	}
}
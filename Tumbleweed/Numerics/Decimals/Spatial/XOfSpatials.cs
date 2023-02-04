using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Decimals.Spatial;

public sealed class XOfSpatials : EnumerableEnvelope<IDecimal>
{
	public XOfSpatials(IEnumerable<ISpatial<IDecimal>> spatials) : base
	(
		new SelectedByExpression<ISpatial<IDecimal>, IDecimal>(
			spatials,
			spatial => spatial.X)
	)
	{
	}
}
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planar;

public sealed class XOfPlanars : EnumerableEnvelope<IDecimal>
{
	public XOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : base
	(
		new SelectedByExpression<IPlanar<IDecimal>, IDecimal>(
			planars,
			planar => planar.X)
	)
	{
	}
}
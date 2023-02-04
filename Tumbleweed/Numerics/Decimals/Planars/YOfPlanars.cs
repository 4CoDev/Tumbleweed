using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Decimals.Planars;

public sealed class YOfPlanars : EnumerableEnvelope<IDecimal>
{
	public YOfPlanars(IEnumerable<IPlanar<IDecimal>> planars) : base
	(
		new SelectedByExpression<IPlanar<IDecimal>, IDecimal>(
			planars,
			planar => planar.Y)
	)
	{
	}
}
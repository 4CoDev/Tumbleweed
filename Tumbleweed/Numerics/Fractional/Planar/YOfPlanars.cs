using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planar;

public sealed class YOfPlanars : EnumerableEnvelope<IFractional>
{
	public YOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : base
	(
		new SelectedByExpression<IPlanar<IFractional>, IFractional>(
			planars,
			planar => planar.Y)
	)
	{
	}
}
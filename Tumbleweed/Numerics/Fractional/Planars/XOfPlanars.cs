using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Planar;

namespace Tumbleweed.Numerics.Fractional.Planars;

public sealed class XOfPlanars : EnumerableEnvelope<IFractional>
{
	public XOfPlanars(IEnumerable<IPlanar<IFractional>> planars) : base
	(
		new SelectedByExpression<IPlanar<IFractional>, IFractional>(
			planars,
			planar => planar.X)
	)
	{
	}
}
using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class YOfPlanars : EnumerableEnvelope<IReal>
{
	public YOfPlanars(IEnumerable<IPlanar<IReal>> planars) : base
	(
		new SelectedByExpression<IPlanar<IReal>, IReal>(
			planars,
			planar => planar.Y)
	)
	{
	}
}
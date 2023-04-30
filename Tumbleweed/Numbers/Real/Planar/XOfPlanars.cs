using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class XOfPlanars : EnumerableEnvelope<IReal>
{
	public XOfPlanars(IEnumerable<IPlanar<IReal>> planars) : base
	(
		new SelectedByExpression<IPlanar<IReal>, IReal>(
			planars,
			planar => planar.X)
	)
	{
	}
}
using Tumbleweed.Enumerables;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class XOfPlanars : EnumerableEnvelope<IReal>
{
	public XOfPlanars(IEnumerable<IPoint<IReal>> planars) : base
	(
		new SelectedByExpression<IPoint<IReal>, IReal>(
			planars,
			planar => planar.X)
	)
	{
	}
}
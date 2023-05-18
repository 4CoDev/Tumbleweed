using Tumbleweed.Enumerables;
using Tumbleweed.Points.Planar;

namespace Tumbleweed.Numbers.Real.Planar;

public sealed class YOfPlanars : EnumerableEnvelope<IReal>
{
	public YOfPlanars(IEnumerable<IPoint<IReal>> planars) : base
	(
		new SelectedByExpression<IPoint<IReal>, IReal>(
			planars,
			planar => planar.Y)
	)
	{
	}
}
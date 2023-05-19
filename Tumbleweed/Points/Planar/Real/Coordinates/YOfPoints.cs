using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Planar.Real.Coordinates;

public sealed class YOfPoints : EnumerableEnvelope<IReal>
{
	public YOfPoints(IEnumerable<IPoint<IReal>> points) : base
	(
		new SelectedByExpression<IPoint<IReal>, IReal>(
			points,
			point => point.Y)
	)
	{
	}
}
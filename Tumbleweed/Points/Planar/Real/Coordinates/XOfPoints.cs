using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Points.Planar.Real.Coordinates;

public sealed class XOfPoints : EnumerableEnvelope<IReal>
{
	public XOfPoints(IEnumerable<IPoint<IReal>> points) : base
	(
		new SelectedByExpression<IPoint<IReal>, IReal>(
			points,
			point => point.X)
	)
	{
	}
}
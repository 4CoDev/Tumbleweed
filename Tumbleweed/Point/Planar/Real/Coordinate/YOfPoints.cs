using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Planar.Real.Coordinate;

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
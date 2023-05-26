using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Planar.Real.Coordinate;

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
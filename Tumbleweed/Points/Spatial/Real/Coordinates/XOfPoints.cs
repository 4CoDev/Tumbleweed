using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

public sealed class XOfPoints : EnumerableEnvelope<IReal>
{
	public XOfPoints(params IPoint<IReal>[] points) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(points)
	)
	{
	}
	
	public XOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : base
	(
		new XOfPoints<IReal>(points)
	)
	{
	}
}
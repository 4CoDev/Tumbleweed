using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Coordinates;

public sealed class ZOfPoints : EnumerableEnvelope<IReal>
{
	public ZOfPoints(params IPoint<IReal>[] points) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(points)
	)
	{
	}
	
	public ZOfPoints
	(
		IEnumerable<IPoint<IReal>> spatials
	) : base
	(
		new ZOfPoints<IReal>(spatials)
	)
	{
	}
}
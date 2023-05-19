using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Comparison;

public sealed class LargestOfPoints : PointEnvelope<IReal>
{
	public LargestOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new EnumerableWithElements<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public LargestOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public LargestOfPoints
	(
		ICollection<IPoint<IReal>> points
	) : base
	(
		new PointWithCoordinates<IReal>(
			new LargestOfReals(new XOfPoints(points)),
			new LargestOfReals(new YOfPoints(points)),
			new LargestOfReals(new ZOfPoints(points)))
	)
	{
	}
}
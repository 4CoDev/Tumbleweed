using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Comparison;
using Tumbleweed.Points.Spatial.Real.Coordinates;

namespace Tumbleweed.Points.Spatial.Real.Comparison;

public sealed class SmallestOfPoints : PointEnvelope<IReal>
{
	public SmallestOfPoints
	(
		params IPoint<IReal>[] spatials
	) : this
	(
		new List<IPoint<IReal>>(spatials)
	)
	{
	}
	
	public SmallestOfPoints
	(
		IEnumerable<IPoint<IReal>> points
	) : this
	(
		new List<IPoint<IReal>>(points)
	)
	{
	}
	
	public SmallestOfPoints
	(
		ICollection<IPoint<IReal>> points
	) : base
	(
		new PointWithCoordinates<IReal>(
			new SmallestOfReals(new XOfPoints(points)),
			new SmallestOfReals(new YOfPoints(points)),
			new SmallestOfReals(new ZOfPoints(points)))
	)
	{
	}
}
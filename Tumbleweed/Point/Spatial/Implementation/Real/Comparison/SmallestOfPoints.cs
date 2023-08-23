using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison.Smallest;
using Tumbleweed.Point.Spatial.Implementation.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Comparison;

public sealed class SmallestOfPoints : Envelope<Any>
{
	public SmallestOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new List<Any<Any>>(spatials)
	)
	{
	}
	
	public SmallestOfPoints
	(
		IEnumerable<Any<Any>> points
	) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public SmallestOfPoints
	(
		ICollection<Any<Any>> points
	) : base
	(
		new Unique<Any>(
			new Multiple(new XOfPoints(points)),
			new Multiple(new YOfPoints(points)),
			new Multiple(new ZOfPoints(points)))
	)
	{
	}
}
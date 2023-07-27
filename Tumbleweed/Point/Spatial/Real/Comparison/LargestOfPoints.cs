using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison.Largest;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

public sealed class LargestOfPoints : Envelope<Any>
{
	public LargestOfPoints
	(
		params Any<Any>[] spatials
	) : this
	(
		new Concatenated<Any<Any>>(spatials)
	)
	{
	}
	
	public LargestOfPoints
	(
		IEnumerable<Any<Any>> points
	) : this
	(
		new List<Any<Any>>(points)
	)
	{
	}
	
	public LargestOfPoints
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
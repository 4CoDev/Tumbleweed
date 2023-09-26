using Tumbleweed.Mathematics.Comparison.Number.Real.Smallest;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Comparison;

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
			new Multiple(new Coordinate.X.Value.Enumerable(points)),
			new Multiple(new Coordinate.Y.Value.Enumerable(points)),
			new Multiple(new Coordinate.Z.Value.Enumerable(points)))
	)
	{
	}
}
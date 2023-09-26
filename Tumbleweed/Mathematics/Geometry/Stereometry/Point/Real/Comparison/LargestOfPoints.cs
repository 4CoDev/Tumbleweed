using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Comparison.Number.Real.Largest;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Comparison;

public sealed class LargestOfPoints : Generic.Envelope<Any>
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
			new Multiple(new Coordinate.X.Value.Enumerable(points)),
			new Multiple(new Coordinate.Y.Value.Enumerable(points)),
			new Multiple(new Coordinate.Z.Value.Enumerable(points)))
	)
	{
	}
}
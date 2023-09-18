using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Comparison.Largest;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.Real.Coordinate.X;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

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
using Tumbleweed.Mathematics.Comparison.Number.Real.Smallest;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.Real.Coordinate.X;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z;

namespace Tumbleweed.Point.Spatial.Real.Comparison;

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
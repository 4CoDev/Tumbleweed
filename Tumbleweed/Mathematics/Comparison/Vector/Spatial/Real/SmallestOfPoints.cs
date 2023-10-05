using Tumbleweed.Mathematics.Comparison.Numerical.Real.Smallest;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;

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
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.X.Value.Enumerable(points)),
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.Enumerable(points)),
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Z.Value.Enumerable(points)))
	)
	{
	}
}
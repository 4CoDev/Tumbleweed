using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Comparison.Numerical.Real.Largest;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;

public sealed class LargestOfPoints : Mathematics.Vector.Spatial.Generic.Envelope<Any>
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
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.X.Value.Enumerable(points)),
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Y.Value.Enumerable(points)),
			new Multiple(new Mathematics.Vector.Spatial.Real.Coordinate.Z.Value.Enumerable(points)))
	)
	{
	}
}
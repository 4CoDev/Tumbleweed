using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.Z.Actual;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Coordinate.Z.Value;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable(params Any<Any>[] points) : this
	(
		new Concatenated<Any<Any>>(points)
	)
	{
	}
	
	public Enumerable
	(
		IEnumerable<Any<Any>> spatials
	) : base
	(
		new Multiple<Any>(spatials)
	)
	{
	}
}
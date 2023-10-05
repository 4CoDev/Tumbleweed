using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate;

public sealed class Enumerable : Envelope<Any>
{
	public Enumerable(IEnumerable<Any> enumerable) : base
	(
		new Collection(
			new List<Any>(enumerable))
	)
	{
	}
}
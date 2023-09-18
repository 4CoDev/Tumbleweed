using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate;

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
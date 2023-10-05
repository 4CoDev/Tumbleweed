using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Real.From.Collection;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.From.Enumerable;

public sealed class Actual : Envelope<Any>
{
	public Actual(IEnumerable<Any> enumerable) : base
	(
		new Collection.Actual(
			new List<Any>(enumerable))
	)
	{
	}
}
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Planar.Real.From.Collection;

public sealed class Actual : Envelope<Any>
{
	public Actual(ICollection<Any> collection) : base
	(
		new Unique<Any>(
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 0),
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 1))
	)
	{
	}
}
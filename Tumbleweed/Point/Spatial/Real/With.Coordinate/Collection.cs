using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate;

public sealed class Collection : Envelope<Any>
{
	public Collection(ICollection<Any> collection) : base
	(
		new Unique<Any>(
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 0),
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 1),
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 2))
	)
	{
	}
}
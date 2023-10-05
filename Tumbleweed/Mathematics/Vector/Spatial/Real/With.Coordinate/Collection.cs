using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate;

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
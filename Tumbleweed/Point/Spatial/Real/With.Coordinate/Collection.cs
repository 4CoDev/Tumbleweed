using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinate;

public sealed class Collection : Envelope<Real::Any>
{
	public Collection(ICollection<Real::Any> collection) : base
	(
		new Unique<Real::Any>(
			new Real::From.Collection.At.Index.System(collection, 0),
			new Real::From.Collection.At.Index.System(collection, 1),
			new Real::From.Collection.At.Index.System(collection, 2))
	)
	{
	}
}
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.With.Coordinates;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Real.With.Coordinates.From;

public sealed class Collection : Envelope<Any>
{
	public Collection(ICollection<Any> collection) : base
	(
		new Unique<Any>(
			new Number.Real.From.Collection.At.Index.System(collection, 0),
			new Number.Real.From.Collection.At.Index.System(collection, 1),
			new Number.Real.From.Collection.At.Index.System(collection, 2))
	)
	{
	}
}
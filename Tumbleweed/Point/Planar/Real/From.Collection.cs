using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Planar.With;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.Real.From;

public sealed class Collection : Envelope<Any>
{
	public Collection(ICollection<Any> collection) : base
	(
		new Coordinates<Any>(
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 0),
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 1))
	)
	{
	}
}
using Tumbleweed.Mathematics.Geometry.Planimetry.Point;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.Real.From;

public sealed class Collection : Envelope<Any>
{
	public Collection(ICollection<Any> collection) : base
	(
		new Unique<Any>(
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 0),
			new Mathematics.Number.Real.From.Collection.At.Index.System(collection, 1))
	)
	{
	}
}
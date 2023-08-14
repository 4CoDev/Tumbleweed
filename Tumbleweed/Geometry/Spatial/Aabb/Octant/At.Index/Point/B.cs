using Tumbleweed.Geometry.Spatial.Aabb.Point;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.From;

namespace Tumbleweed.Geometry.Spatial.Aabb.Octant.At.Index.Point;

public sealed class B : Envelope<Tumbleweed.Number.Real.Any>
{
	public B
	(
		Any space,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new SumOfPoints(
			new Center(space),
			new ProductOfPoints(
				new Size.Half.One(space),
				new Natural(index)))
	)
	{
	}
}
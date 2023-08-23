using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Implementation.Real.From;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.A.Actual;

namespace Tumbleweed.Geometry.Spatial.Aabb.Octant.At.Index.Point;

public sealed class A : Envelope<Tumbleweed.Number.Real.Any>
{
	public A
	(
		Any space,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new SumOfPoints(
			new Actual(space),
			new ProductOfPoints(
				new Size.Half.One(space),
				new Natural(index)))
	)
	{
	}
}
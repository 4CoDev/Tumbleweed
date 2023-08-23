using Tumbleweed.Number.Natural.Point.Spatial.From;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic.Rounding;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.A.Actual;

namespace Tumbleweed.Geometry.Spatial.Aabb.Octant.Collided.By.Point.Index;

public sealed class One : Envelope<Tumbleweed.Number.Natural.Any>
{
	public One
	(
		Any aabb,
		Any<Tumbleweed.Number.Real.Any> point
	) : this
	(
		new Size.Whole.One(aabb),
		new DifferenceOfPoints(
			point,
			new Actual(aabb))
	)
	{
	}

	public One
	(
		Any<Tumbleweed.Number.Real.Any> size,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Real(
			new NearestIntegerOfPoint(
				new QuotientOfPoints(point, size)))
	)
	{
	}
}
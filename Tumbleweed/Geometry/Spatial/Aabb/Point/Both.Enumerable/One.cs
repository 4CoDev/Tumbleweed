using Tumbleweed.Point.Spatial;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.B.Actual;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Geometry.Spatial.Aabb.Point.Both.Enumerable;

public sealed class One : Tumbleweed.Enumerable.Envelope<Any<Tumbleweed.Number.Real.Any>>
{
	public One(Any occupation) : base
	(
		new Enumerable::From.Array<Any<Tumbleweed.Number.Real.Any>>(
			new A.Actual(occupation),
			new Actual(occupation))
	)
	{
	}
}
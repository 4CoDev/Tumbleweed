using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Spatial.Aabb.Point;

public sealed class Center : Envelope<Tumbleweed.Number.Real.Any>
{
	public Center(Any space) : base
	(
		new QuotientByReal(
			new SumOfPoints(
				new Actual(space),
				new Point.A.Actual(space)),
			2)
	)
	{
	}
}
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;
using Actual = Tumbleweed.Geometry.Spatial.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Spatial.Aabb.Size.Whole;

public sealed class One : Envelope<Tumbleweed.Number.Real.Any>
{
	public One(Any space) : base
	(
		new L1BetweenPoints(
			new Point.A.Actual(space),
			new Actual(space))
	)
	{
	}
}
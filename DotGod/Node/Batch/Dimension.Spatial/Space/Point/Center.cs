using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.B.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Point;

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
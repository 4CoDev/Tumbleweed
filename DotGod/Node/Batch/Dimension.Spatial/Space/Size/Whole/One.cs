using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.B.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Size.Whole;

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
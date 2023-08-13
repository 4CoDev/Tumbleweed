using Tumbleweed.Point.Spatial;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.B.Actual;
using Enumerable = Tumbleweed.Enumerable;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Point.Both.Enumerable;

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
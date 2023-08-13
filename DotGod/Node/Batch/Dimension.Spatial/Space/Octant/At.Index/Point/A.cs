using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.From;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.A.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Octant.At.Index.Point;

public sealed class A : Envelope<Tumbleweed.Number.Real.Any>
{
	public A
	(
		Spaced.Any batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : this
	(
		new Spaced.Member.Space.One(batch),
		index
	)
	{
	}
	
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
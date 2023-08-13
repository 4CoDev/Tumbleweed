using DotGod.Node.Batch.Dimension.Spatial.Space.Point;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.From;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Octant.At.Index.Point;

public sealed class B : Envelope<Tumbleweed.Number.Real.Any>
{
	public B
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
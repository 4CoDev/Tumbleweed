using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.From;

namespace DotGod.Spatial._Node.Batch.Space.Octants.Points;

public sealed class ToPointWithIndex : Envelope<Tumbleweed.Number.Real.Any>
{
	public ToPointWithIndex
	(
		Spaced.Abstract.IBatch batch,
		Any<Tumbleweed.Number.Natural.Any> index
	) : this
	(
		new Spaced.Batch.Space.Of.Batch(batch),
		index
	)
	{
	}
	
	public ToPointWithIndex
	(
		ISpace space,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new SumOfPoints(
			new CenterOfSpace(space),
			new ProductOfPoints(
				new HalfOfSpace(space),
				new Natural(index)))
	)
	{
	}
}
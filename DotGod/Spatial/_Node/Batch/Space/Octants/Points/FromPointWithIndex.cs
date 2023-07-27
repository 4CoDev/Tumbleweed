using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.From;

namespace DotGod.Spatial._Node.Batch.Space.Octants.Points;

public sealed class FromPointWithIndex : Envelope<Tumbleweed.Number.Real.Any>
{
	public FromPointWithIndex
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
	
	public FromPointWithIndex
	(
		ISpace space,
		Any<Tumbleweed.Number.Natural.Any> index
	) : base
	(
		new SumOfPoints(
			new FromPointOfSpace(space),
			new ProductOfPoints(
				new HalfOfSpace(space),
				new Natural(index)))
	)
	{
	}
}
using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Number.Natural.Point.Spatial;
using Tumbleweed.Number.Natural.Point.Spatial.From;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Rounding;

namespace DotGod.Spatial._Node.Batch.Space.Octants;

public sealed class OctantIndexWithPoint : Envelope<Tumbleweed.Number.Natural.Any>
{
	public OctantIndexWithPoint
	(
		Spaced.Abstract.IBatch batch,
		Any<Tumbleweed.Number.Real.Any> point
	) : this
	(
		new Spaced.Batch.Space.Of.Batch(batch),
		point
	)
	{
	}
	
	public OctantIndexWithPoint
	(
		ISpace space,
		Any<Tumbleweed.Number.Real.Any> point
	) : this
	(
		new SizeOfSpace(space),
		new DifferenceOfPoints(
			point,
			new FromPointOfSpace(space))
	)
	{
	}

	public OctantIndexWithPoint
	(
		Any<Tumbleweed.Number.Real.Any> size,
		Any<Tumbleweed.Number.Real.Any> point
	) : base
	(
		new Real(
			new NearestIntegerOfPoint(
				new QuotientOfPoints(point, size)))
	)
	{
	}
}
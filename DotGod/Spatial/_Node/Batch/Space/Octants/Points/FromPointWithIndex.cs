using DotGod.Spatial._Node.Batch.Space.Points;
using DotGod.Spatial._Node.Spaced.Batch;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real;
using Tumbleweed.Spatial.Point.Real.Arithmetic;
using IRealNumber = Tumbleweed.Number.Real.IReal;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod.Spatial._Node.Batch.Space.Octants.Points;

public sealed class FromPointWithIndex : PointEnvelope<IRealNumber>
{
	public FromPointWithIndex
	(
		ISpacedBatch batch,
		IPoint<INaturalNumber> index
	) : this
	(
		new SpaceOfBatch(batch),
		index
	)
	{
	}
	
	public FromPointWithIndex
	(
		ISpace space,
		IPoint<INaturalNumber> index
	) : base
	(
		new SumOfPoints(
			new FromPointOfSpace(space),
			new ProductOfPoints(
				new HalfOfSpace(space),
				new RealFromNatural(index)))
	)
	{
	}
}
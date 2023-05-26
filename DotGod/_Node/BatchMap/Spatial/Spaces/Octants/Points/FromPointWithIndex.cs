using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using IRealNumber = Tumbleweed.Number.Real.IReal;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Octants.Points;

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
using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real;
using Tumbleweed.Point.Spatial.Real.Arithmetic;
using IRealNumber = Tumbleweed.Number.Real.IReal;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Octants.Points;

public sealed class ToPointWithIndex : PointEnvelope<IRealNumber>
{
	public ToPointWithIndex
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
	
	public ToPointWithIndex
	(
		ISpace space,
		IPoint<INaturalNumber> index
	) : base
	(
		new SumOfPoints(
			new CenterOfSpace(space),
			new ProductOfPoints(
				new HalfOfSpace(space),
				new RealFromNatural(index)))
	)
	{
	}
}
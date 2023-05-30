using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real;
using Tumbleweed.Spatial.Point.Real.Arithmetic;
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
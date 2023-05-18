using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real.Spatial;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants.Points;

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
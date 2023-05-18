using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using Tumbleweed.Numbers.Real.Spatial;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants.Points;

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
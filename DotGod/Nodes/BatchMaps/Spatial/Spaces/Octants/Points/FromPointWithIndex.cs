using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real.Spatial;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants.Points;

public sealed class FromPointWithIndex : SpatialEnvelope<IRealNumber>
{
	public FromPointWithIndex
	(
		ISpacedBatch batch,
		ISpatial<INaturalNumber> index
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
		ISpatial<INaturalNumber> index
	) : base
	(
		new SumOfSpatials(
			new FromPointOfSpace(space),
			new ProductOfSpatials(
				new HalfOfSpace(space),
				new RealFromNatural(index)))
	)
	{
	}
}
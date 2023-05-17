using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Integers.Natural.Spatial;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Arithmetics.Rounding;
using Tumbleweed.Points.Spatial;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;

public sealed class OctantIndexWithPoint : SpatialEnvelope<INaturalNumber>
{
	public OctantIndexWithPoint
	(
		ISpacedBatch batch,
		ISpatial<IRealNumber> point
	) : this
	(
		new SpaceOfBatch(batch),
		point
	)
	{
	}
	
	public OctantIndexWithPoint
	(
		ISpace space,
		ISpatial<IRealNumber> point
	) : this
	(
		new SizeOfSpace(space),
		new DifferenceOfSpatials(
			point,
			new FromPointOfSpace(space))
	)
	{
	}

	public OctantIndexWithPoint
	(
		ISpatial<IRealNumber> size,
		ISpatial<IRealNumber> point
	) : base
	(
		new NaturalFromReal(
			new NearestIntegerOfSpatial(
				new QuotientOfSpatials(point, size)))
	)
	{
	}
}
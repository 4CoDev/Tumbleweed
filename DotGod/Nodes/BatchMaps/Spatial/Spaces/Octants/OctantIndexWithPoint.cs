using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Integers.Natural.Spatial;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Real.Arithmetics;
using Tumbleweed.Points.Spatial.Real.Arithmetics.Rounding;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;

public sealed class OctantIndexWithPoint : PointEnvelope<INaturalNumber>
{
	public OctantIndexWithPoint
	(
		ISpacedBatch batch,
		IPoint<IRealNumber> point
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
		IPoint<IRealNumber> point
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
		IPoint<IRealNumber> size,
		IPoint<IRealNumber> point
	) : base
	(
		new NaturalFromReal(
			new NearestIntegerOfPoint(
				new QuotientOfPoints(point, size)))
	)
	{
	}
}
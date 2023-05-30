using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed.Number.Integer.Natural.Spatial;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Real.Arithmetic;
using Tumbleweed.Spatial.Point.Real.Arithmetic.Rounding;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace DotGod._Node.BatchMap.Spatial.Spaces.Octants;

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
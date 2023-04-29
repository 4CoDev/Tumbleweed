using DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Fractional.Spatial.Comparison;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class NormalizedSpace : IOccupiedSpace
{
	public NormalizedSpace(IOccupiedSpace occupation) =>
		this.occupation = occupation;

	public ISpatial<IFractional> From => 
	(
		new SmallestOfSpatials(
			new BothPointsOfSpace(occupation))
	);

	public ISpatial<IFractional> To => 
	(
		new LargestOfSpatials(
			new BothPointsOfSpace(occupation))
	);

	private readonly IOccupiedSpace occupation;
}
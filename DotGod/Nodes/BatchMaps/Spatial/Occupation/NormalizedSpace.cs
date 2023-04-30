using DotGod.Nodes.BatchMaps.Spatial.Occupation.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class NormalizedSpace : IOccupiedSpace
{
	public NormalizedSpace(IOccupiedSpace occupation) =>
		this.occupation = occupation;

	public ISpatial<IReal> From => 
	(
		new SmallestOfSpatials(
			new BothPointsOfSpace(occupation))
	);

	public ISpatial<IReal> To => 
	(
		new LargestOfSpatials(
			new BothPointsOfSpace(occupation))
	);

	private readonly IOccupiedSpace occupation;
}
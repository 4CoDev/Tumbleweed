using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Spatial.Comparison;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class NormalizedSpace : ISpace
{
	public NormalizedSpace(ISpace occupation) =>
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

	private readonly ISpace occupation;
}
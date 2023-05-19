using DotGod.Nodes.BatchMaps.Spatial.Spaces.Points;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Real.Comparison;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class NormalizedSpace : ISpace
{
	public NormalizedSpace(ISpace occupation) =>
		this.occupation = occupation;

	public IPoint<IReal> From => 
	(
		new SmallestOfPoints(
			new BothPointsOfSpace(occupation))
	);

	public IPoint<IReal> To => 
	(
		new LargestOfPoints(
			new BothPointsOfSpace(occupation))
	);

	private readonly ISpace occupation;
}
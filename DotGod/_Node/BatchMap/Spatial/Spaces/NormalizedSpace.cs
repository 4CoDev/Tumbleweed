using DotGod._Node.BatchMap.Spatial.Spaces.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

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
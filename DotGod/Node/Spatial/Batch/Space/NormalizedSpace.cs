using DotGod.Node.Spatial.Batch.Space.Points;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class NormalizedSpace : ISpace
{
	public NormalizedSpace(ISpace occupation) =>
		this.occupation = occupation;

	public Any<Tumbleweed.Number.Real.Any> From => 
	(
		new SmallestOfPoints(
			new BothPointsOfSpace(occupation))
	);

	public Any<Tumbleweed.Number.Real.Any> To => 
	(
		new LargestOfPoints(
			new BothPointsOfSpace(occupation))
	);

	private readonly ISpace occupation;
}
using DotGod.Spatial._Node.Batch.Space.Points;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace DotGod.Spatial._Node.Batch.Space;

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
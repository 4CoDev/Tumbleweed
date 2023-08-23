using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Implementation.Real.Comparison;

namespace Tumbleweed.Geometry.Spatial.Aabb.Normalized;

public sealed class One : Any
{
	public One(Any occupation) =>
		this.occupation = occupation;

	public Any<Tumbleweed.Number.Real.Any> A => 
	(
		new SmallestOfPoints(
			new Point.Both.Enumerable.One(occupation))
	);

	public Any<Tumbleweed.Number.Real.Any> B => 
	(
		new LargestOfPoints(
			new Point.Both.Enumerable.One(occupation))
	);

	private readonly Any occupation;
}
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Comparison;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Normalized;

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
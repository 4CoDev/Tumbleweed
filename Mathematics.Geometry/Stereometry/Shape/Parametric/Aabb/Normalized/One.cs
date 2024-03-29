using Tumbleweed.Mathematics.Comparison.Vector.Spatial.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Normalized;

public sealed class One : Any
{
	public One(Any occupation) =>
		this.occupation = occupation;

	public Any<Mathematics.Number.Real.Any> A => 
	(
		new SmallestOfPoints(
			new Point.Both.Enumerable.One(occupation))
	);

	public Any<Mathematics.Number.Real.Any> B => 
	(
		new LargestOfPoints(
			new Point.Both.Enumerable.One(occupation))
	);

	private readonly Any occupation;
}
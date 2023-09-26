using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

public abstract class Envelope : Any
{
	protected Envelope(Any aabb) =>
		this.aabb = aabb;

	public Any<Mathematics.Number.Real.Any> A =>
		aabb.A;

	public Any<Mathematics.Number.Real.Any> B =>
		aabb.B;

	private readonly Any aabb;
}
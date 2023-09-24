using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb;

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
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb;

public abstract class Envelope : Any
{
	protected Envelope(Any aabb) =>
		this.aabb = aabb;

	public Any<Tumbleweed.Number.Real.Any> A =>
		aabb.A;

	public Any<Tumbleweed.Number.Real.Any> B =>
		aabb.B;

	private readonly Any aabb;
}
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> any) =>
		this.any = any;

	public Any<Tumbleweed.Number.Real.Any> A =>
		any.Value.A;

	public Any<Tumbleweed.Number.Real.Any> B =>
		any.Value.B;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Any> any;
}
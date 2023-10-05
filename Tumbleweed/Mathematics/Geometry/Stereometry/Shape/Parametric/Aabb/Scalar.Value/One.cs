using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> any) =>
		this.any = any;

	public Any<Mathematics.Number.Real.Any> A =>
		any.Value.A;

	public Any<Mathematics.Number.Real.Any> B =>
		any.Value.B;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Any> any;
}
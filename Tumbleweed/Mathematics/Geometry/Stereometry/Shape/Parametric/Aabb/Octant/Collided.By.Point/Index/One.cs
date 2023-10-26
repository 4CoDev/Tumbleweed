using Godot;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number = Tumbleweed.Mathematics.Number;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;
using Arithmetic = Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real;
using Stereometry = Tumbleweed.Mathematics.Geometry.Stereometry;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.Collided.By.Point.Index;

public sealed class One : Vector::Generic.Envelope<Number::Natural.Any>
{
	public One
	(
		Aabb::Any aabb,
		Vector::Generic.Any<Number::Real.Any> point
	) : this
	(
		new Size.Whole.One(aabb),
		new Arithmetic::Difference.Just.Of.Multiple(
			point,
			new Stereometry::Shape.Parametric.Aabb.Point.A.Actual(aabb))
	)
	{
	}
	
	public One
	(
		Vector::Generic.Any<Number::Real.Any> size,
		Vector::Generic.Any<Number::Real.Any> point
	) : base
	(
		new Arithmetic::Rounding.Nearest.As.Natural(
			new Arithmetic::Quotient.Scalar.Of.Point.Multiple(point, size))
	)
	{
	}
}
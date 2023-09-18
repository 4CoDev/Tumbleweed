using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using SCG = System.Collections.Generic;
using Sum = Tumbleweed.Point.Spatial.Real.Arithmetic.Sum;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Enumerable.With.Point;

public sealed class Real : Enumerable::Envelope<Point::Generic.Any<Real::Any>>
{
	public Real
	(
		SCG::IEnumerable<Point::Generic.Any<Real::Any>> augends,
		Point::Generic.Any<Real::Any> addend
	) : base
	(
		new Enumerable::Selected<Point::Generic.Any<Real::Any>>(
			augends,
			augend => new Sum::Scalar.Of.Multiple(augend, addend))
	)
	{
	}
}
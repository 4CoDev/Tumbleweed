using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using SCG = System.Collections.Generic;
using Sum = Tumbleweed.Point.Spatial.Real.Arithmetic.Sum;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Sum.Enumerable.With.Point;

public sealed class Real : Enumerable::Envelope<Point::Generic.Any<Any>>
{
	public Real
	(
		SCG::IEnumerable<Point::Generic.Any<Any>> augends,
		Point::Generic.Any<Any> addend
	) : base
	(
		new Enumerable::Selected<Point::Generic.Any<Any>>(
			augends,
			augend => new Sum::Scalar.Of.Multiple(augend, addend))
	)
	{
	}
}
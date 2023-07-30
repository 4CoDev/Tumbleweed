using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double;

namespace Tumbleweed.Point.Spatial.Real.With.Coordinates.Directly;

public sealed class Uniform : Point::Envelope<Real::Any>
{
	public Uniform
	(
		System::Single coordinate
	) : this
	(
		new Single::From.System.One(coordinate)
	)
	{
	}
	
	public Uniform
	(Tumbleweed.Scalar.Immutable.Any<System::Single> coordinate
	) : this
	(
		new Single::From.System.One(coordinate)
	)
	{
	}
	
	public Uniform
	(
		System::Double coordinate
	) : this
	(
		new Double::From.System.One(coordinate)
	)
	{
	}
	
	public Uniform
	(Tumbleweed.Scalar.Immutable.Any<System::Double> coordinate
	) : this
	(
		new Double::From.System.One(coordinate)
	)
	{
	}
	
	public Uniform(Real::Any coordinate) : base
	(
		new Point::Real.With.Coordinates.Directly.Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}
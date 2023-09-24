using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

public sealed class Unique : Point::Generic.Envelope<Any>
{
	public Unique
	(
		System::Single x,
		System::Single y,
		System::Single z
	) : this
	(
		new Scalar::With.Value<System::Single>(x),
		new Scalar::With.Value<System::Single>(y),
		new Scalar::With.Value<System::Single>(z)
	)
	{
	}
	
	public Unique
	(
		Scalar::Any<System::Single> x,
		Scalar::Any<System::Single> y,
		Scalar::Any<System::Single> z
	) : base
	(
		 new Point::Real.Base.Binary.Precision.Single.From.System.One(
			 new Point::Generic.With.Coordinate.Definition.Unique
				 <System::Single>
				 (x, y, z))
	)
	{
	}
}
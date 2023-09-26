using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.From.System;
using Tumbleweed.Mathematics.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

public sealed class Unique : Generic.Envelope<Any>
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
		 new One(
			 new Unique
				 <System::Single>
				 (x, y, z))
	)
	{
	}
}
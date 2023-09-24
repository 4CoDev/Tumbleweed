using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Definition = Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

namespace Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

public sealed class Uniform : Point::Generic.Envelope<Any>
{
	public Uniform
	(
		System::Single coordinate
	) : this
	(
		new Scalar::With.Value
			<System::Single>
			(coordinate)
	)
	{
	}
	
	public Uniform
	(
		Scalar::Any<System::Single> coordinate
	) : base
	(
		new Definition::Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}
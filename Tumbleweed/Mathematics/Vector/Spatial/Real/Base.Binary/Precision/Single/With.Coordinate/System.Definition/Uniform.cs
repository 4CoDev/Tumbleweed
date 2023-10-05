using Tumbleweed.Mathematics.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

public sealed class Uniform : Generic.Envelope<Any>
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
		new Unique(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}
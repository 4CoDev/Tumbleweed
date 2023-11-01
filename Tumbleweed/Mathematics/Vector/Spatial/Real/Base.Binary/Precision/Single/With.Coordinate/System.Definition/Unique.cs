using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.From.System;
using System = System;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

public sealed class Unique : Generic.Envelope<Any>
{
	public Unique
	(
		System::Single x,
		System::Single y,
		System::Single z
	) : this
	(
		new Property::With.Value<System::Single>(x),
		new Property::With.Value<System::Single>(y),
		new Property::With.Value<System::Single>(z)
	)
	{
	}
	
	public Unique
	(
		Property::Any<System::Single> x,
		Property::Any<System::Single> y,
		Property::Any<System::Single> z
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
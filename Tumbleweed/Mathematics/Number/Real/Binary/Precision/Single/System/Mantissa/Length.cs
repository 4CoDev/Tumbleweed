using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Length : Property::Envelope<System::Int32>
{
	public Length() : base
	(
		new Property::With.Value<System::Int32>(23)
	)
	{
	}
}
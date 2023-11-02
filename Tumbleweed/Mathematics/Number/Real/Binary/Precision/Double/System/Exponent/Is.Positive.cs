using Tumbleweed.Mathematics.Boolean.From.Enumerable.At.Index;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

using Property = Tumbleweed.Property;
using System = System;
using Double = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent.Is;

public sealed class Positive : Boolean.Envelope
{
	public Positive(System::Double @double) : this
	(
		new One<System::Double>(@double)
	)
	{
	}
	
	public Positive(Any<System::Double> @double) : base
	(
		new Boolean.From.Enumerable.At.Index.System(
			new Bits(@double),
			62)
	)
	{
	}
}
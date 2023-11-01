using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;

using System = System;
using Property = Tumbleweed.Property;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Equals.To.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single first,
		System::Single second
	) : this
	(
		new Value<System::Single>(first),
		new Value<System::Single>(second)
	)
	{
	}
	
	public One
	(
		Any<System::Single> first,
		Any<System::Single> second
	) : base
	(
		new Boolean.From.System.One(
			new Actual(
				() => second.Value < first.Value))
	)
	{
	}
}
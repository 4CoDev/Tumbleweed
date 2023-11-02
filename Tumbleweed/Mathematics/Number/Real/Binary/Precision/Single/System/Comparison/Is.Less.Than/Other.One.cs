using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

using System = System;
using Property = Tumbleweed.Property;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Less.Than.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single smaller,
		System::Single larger
	) : this
	(
		new One<System::Single>(smaller),
		new One<System::Single>(larger)
	)
	{
	}
	
	public One
	(
		Any<System::Single> smaller,
		Any<System::Single> larger
	) : base
	(
		new Boolean.From.System.One(
			new Actual(
				() => larger.Value < smaller.Value))
	)
	{
	}
}
using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

using System = System;
using Property = Tumbleweed.Property;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Greater.Than.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single larger,
		System::Single smaller
	) : this
	(
		new One<System::Single>(larger),
		new One<System::Single>(smaller)
	)
	{
	}
	
	public One
	(
		Any<System::Single> larger,
		Any<System::Single> smaller
	) : base
	(
		new Boolean.From.System.One(
			new Actual(
				() => larger.Value > smaller.Value))
	)
	{
	}
}
using Tumbleweed.Mathematics.Comparison.Boolean.Either.Is;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

using System = System;
using Property = Tumbleweed.Property;
using Comparison = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.
	Comparison;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Greater.Than.Or.Equals.To.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single first,
		System::Single second
	) : this
	(
		new One<System::Single>(first),
		new One<System::Single>(second)
	)
	{
	}
	
	public One
	(
		Any<System::Single> first,
		Any<System::Single> second
	) : base
	(
		new True(
			new Comparison::Is.Equals.To.Other.One(first, second),
			new Comparison::Is.Greater.Than.Other.One(first, second))
	)
	{
	}
}
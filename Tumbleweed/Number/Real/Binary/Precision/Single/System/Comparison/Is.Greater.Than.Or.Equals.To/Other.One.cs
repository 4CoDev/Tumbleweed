using Tumbleweed.Boolean.Comparison.Either.Is;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Comparison = Tumbleweed.Number.Real.Binary.Precision.Single.System.
	Comparison;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Greater.Than.Or.Equals.To.Other;

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
		new True(
			new Comparison::Is.Equals.To.Other.One(first, second),
			new Comparison::Is.Greater.Than.Other.One(first, second))
	)
	{
	}
}
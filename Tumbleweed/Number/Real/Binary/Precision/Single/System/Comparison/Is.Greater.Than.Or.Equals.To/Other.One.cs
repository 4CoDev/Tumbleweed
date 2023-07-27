using Tumbleweed.Boolean.Comparison.Either.Is;
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
		new Scalar::Of.Value<System::Single>(first),
		new Scalar::Of.Value<System::Single>(second)
	)
	{
	}
	
	public One
	(
		Scalar::Any<System::Single> first,
		Scalar::Any<System::Single> second
	) : base
	(
		new True(
			new Comparison::Is.Equals.To.Other.One(first, second),
			new Comparison::Is.Greater.Than.Other.One(first, second))
	)
	{
	}
}
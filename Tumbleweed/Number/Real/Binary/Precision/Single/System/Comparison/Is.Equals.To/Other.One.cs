using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Equals.To.Other;

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
		new Boolean.From.System.One(
			new Boolean::System.Function.Result(
				() => second.Value < first.Value))
	)
	{
	}
}
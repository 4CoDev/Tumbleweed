using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Less.Than.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single smaller,
		System::Single larger
	) : this
	(
		new Scalar::Of.Value<System::Single>(smaller),
		new Scalar::Of.Value<System::Single>(larger)
	)
	{
	}
	
	public One
	(
		Scalar::Any<System::Single> smaller,
		Scalar::Any<System::Single> larger
	) : base
	(
		new Boolean.From.System.One(
			new Boolean::System.Function.Result(
				() => larger.Value < smaller.Value))
	)
	{
	}
}
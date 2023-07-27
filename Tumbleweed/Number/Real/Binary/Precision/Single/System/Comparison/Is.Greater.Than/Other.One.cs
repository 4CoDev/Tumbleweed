using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison.Is.
	Greater.Than.Other;

public sealed class One : Boolean.Envelope
{
	public One
	(
		System::Single larger,
		System::Single smaller
	) : this
	(
		new Scalar::Of.Value<System::Single>(larger),
		new Scalar::Of.Value<System::Single>(smaller)
	)
	{
	}
	
	public One
	(
		Scalar::Any<System::Single> larger,
		Scalar::Any<System::Single> smaller
	) : base
	(
		new Boolean.From.System.One(
			new Boolean::System.Function.Result(
				() => larger.Value > smaller.Value))
	)
	{
	}
}
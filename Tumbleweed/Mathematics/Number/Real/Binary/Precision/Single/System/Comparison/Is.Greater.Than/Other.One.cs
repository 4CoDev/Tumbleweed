using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

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
		new Value<System::Single>(larger),
		new Value<System::Single>(smaller)
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
			new Boolean::System.Function.Result(
				() => larger.Value > smaller.Value))
	)
	{
	}
}
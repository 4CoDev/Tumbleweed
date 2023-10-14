using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

using System = System;
using Scalar = Tumbleweed.Scalar;

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
		new Value<System::Single>(smaller),
		new Value<System::Single>(larger)
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
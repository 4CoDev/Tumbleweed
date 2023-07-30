using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
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
		new Boolean.From.System.One(
			new Boolean::System.Function.Result(
				() => second.Value < first.Value))
	)
	{
	}
}
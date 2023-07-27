using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.Comparison;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;
using One = Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Number.Real.Comparison.Smallest;

public sealed class Multiple : Envelope
{
	public Multiple(params Real.Any[] numbers) : this
	(
		new Concatenated<Any>(numbers)
	)
	{
	}
	
	public Multiple(IEnumerable<Real.Any> numbers) : base
	(
		new One(
			new Binary.Precision.Single.System.Comparison.Smallest(
				new Binary.Precision.Single.System.From.Tumbleweed.Multiple(numbers)))
	)
	{
	}
}
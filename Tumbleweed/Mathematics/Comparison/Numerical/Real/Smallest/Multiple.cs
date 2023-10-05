using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Number.Real.Envelope;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One;

namespace Tumbleweed.Mathematics.Comparison.Numerical.Real.Smallest;

public sealed class Multiple : Envelope
{
	public Multiple(params Any[] numbers) : this
	(
		new Concatenated<Any>(numbers)
	)
	{
	}
	
	public Multiple(IEnumerable<Any> numbers) : base
	(
		new One(
			new Mathematics.Number.Real.Binary.Precision.Single.System.Comparison.Smallest(
				new Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.Multiple(numbers)))
	)
	{
	}
}
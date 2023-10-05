using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Absolute;
using Tumbleweed.Mathematics.Number.Real;
using Envelope = Tumbleweed.Mathematics.Number.Real.Envelope;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Difference.Absolute.Of;

public sealed class Multiple : Envelope
{
	public Multiple
	(
		params Any[] reals
	) : this
	(
		new Concatenated<Any>(reals)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Any> reals) : base
	(
		new One(
			new Just.Of.Multiple(reals))
	)
	{
	}
}
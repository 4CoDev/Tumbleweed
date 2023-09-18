using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real.Arithmetic.Absolute;

namespace Tumbleweed.Number.Real.Arithmetic.Difference.Absolute.Of;

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
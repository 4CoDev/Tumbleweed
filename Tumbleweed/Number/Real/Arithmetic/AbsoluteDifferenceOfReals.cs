using Tumbleweed.Enumerable;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfReals : Envelope
{
	public AbsoluteDifferenceOfReals
	(
		params Any[] reals
	) : this
	(
		new Concatenated<Any>(reals)
	)
	{
	}
	
	public AbsoluteDifferenceOfReals
	(
		IEnumerable<Any> reals) : base
	(
		new AbsoluteReal(
			new DifferenceOfReals(reals))
	)
	{
	}
}
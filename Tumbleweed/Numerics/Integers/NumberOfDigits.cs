using Tumbleweed.Numerics.Integers.Arithmetics;

namespace Tumbleweed.Numerics.Integers;

public sealed class NumberOfDigits : IntegerEnvelope
{
	public NumberOfDigits(IInteger integer) : base
	(
		new Logarithm(integer)
	)
	{
	}
}
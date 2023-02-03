using Tumbleweed.Numerics.Integers.Arithmetic;

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
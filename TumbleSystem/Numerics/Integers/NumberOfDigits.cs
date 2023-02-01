using TumbleSystem.Numerics.Integers.Arithmetic;
using Tumbleweed.Numerics.Integers;

namespace TumbleSystem.Numerics.Integers;

public sealed class NumberOfDigits : IntegerEnvelope
{
	public NumberOfDigits(IInteger integer) : base
	(
		new CommonLogarithm(integer)
	)
	{
	}
}
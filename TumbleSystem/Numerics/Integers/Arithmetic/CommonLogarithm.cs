using TumbleSystem.Numerics.Integers.FromSystem;
using Tumbleweed.Numerics.Integers;

namespace TumbleSystem.Numerics.Integers.Arithmetic;

public sealed class CommonLogarithm : IntegerEnvelope
{
	public CommonLogarithm(IInteger argument) : base
	(
		new Logarithm(new IntegerFromInt32(10), argument)
	)
	{
	}
}
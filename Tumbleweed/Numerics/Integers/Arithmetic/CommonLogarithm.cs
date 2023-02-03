using Tumbleweed.Numerics.Integers.FromSystem;

namespace Tumbleweed.Numerics.Integers.Arithmetic;

public sealed class CommonLogarithm : IntegerEnvelope
{
	public CommonLogarithm(IInteger argument) : base
	(
		new Logarithm(new IntegerFromInt32(10), argument)
	)
	{
	}
}
using Tumbleweed.Numerics.Integers.FromSystem;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Arithmetic;

public sealed class Logarithm : IntegerEnvelope
{
	public Logarithm(IInteger argument) : this
	(
		new IntegerFromInt32(10), argument
	)
	{
	}

	public Logarithm(IInteger @base, IInteger argument) : base
	(
		new IntegerFromInt32(
			new ScalarOfDelegate<int>(
				() => (int)Math.Log(
					new NumberFromInteger(@base).Value(),
					new NumberFromInteger(argument).Value())))
	)
	{
	}
}
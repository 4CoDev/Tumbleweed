using Tumbleweed.Numerics.Integers.FromSystem;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Arithmetics;

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
			new ValueOfDelegate<int>(
				() => (int)Math.Log(
					new Int32FromInteger(@base).Value,
					new Int32FromInteger(argument).Value)))
	)
	{
	}
}
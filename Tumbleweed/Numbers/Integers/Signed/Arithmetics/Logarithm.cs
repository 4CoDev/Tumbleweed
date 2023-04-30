using Tumbleweed.Numbers.Integers.Signed.FromSystem;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.Arithmetics;

public sealed class Logarithm : SignedEnvelope
{
	public Logarithm(ISigned argument) : this
	(
		new SignedFromInt32(10), argument
	)
	{
	}

	public Logarithm(ISigned @base, ISigned argument) : base
	(
		new SignedFromInt32(
			new ValueOfFunction<Int32>(
				() => (Int32)Math.Log(
					new Int32FromSigned(@base).Value,
					new Int32FromSigned(argument).Value)))
	)
	{
	}
}
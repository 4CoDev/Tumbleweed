using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.Arithmetics;

public sealed class Logarithm : SignedEnvelope
{
	public Logarithm(ISignedInteger argument) : this
	(
		new SignedFromInt32(10), argument
	)
	{
	}

	public Logarithm(ISignedInteger @base, ISignedInteger argument) : base
	(
		new SignedFromInt32(
			new ValueOfDelegate<Int32>(
				() => (Int32)Math.Log(
					new Int32FromSigned(@base).Value,
					new Int32FromSigned(argument).Value)))
	)
	{
	}
}
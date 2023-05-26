using Tumbleweed.Number.Integer.Signed.FromSystem;
using Tumbleweed.Number.Integer.Signed.ToSystem._Int32;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.Arithmetic;

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
			new ResultOfFunction<Int32>(
				() => (Int32)Math.Log(
					new Int32FromSigned(@base).Value,
					new Int32FromSigned(argument).Value)))
	)
	{
	}
}
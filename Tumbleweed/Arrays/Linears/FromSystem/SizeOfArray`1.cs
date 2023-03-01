using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.FromSystem;

public sealed class SizeOfArray<T> : SignedEnvelope
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new SignedFromInt32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}
using Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.FromSystem;

public class SignedFromInt32 : SignedEnvelope
{
	public SignedFromInt32(int integer) : this
	(
		new ScalarOfValue<int>(integer)
	)
	{
	}

	public SignedFromInt32(IScalar<int> ints) : base
	(
		new SignedWithValues(
			new IsPositiveInt32(ints), 
			new NaturalFromInt32(ints))
	)
	{
	}
}
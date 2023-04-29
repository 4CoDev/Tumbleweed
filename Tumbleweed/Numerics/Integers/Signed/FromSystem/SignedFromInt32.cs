using Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromInts32;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.FromSystem;

public class SignedFromInt32 : SignedEnvelope
{
	public SignedFromInt32(Int32 integer) : this
	(
		new ScalarValue<Int32>(integer)
	)
	{
	}

	public SignedFromInt32(IScalar<Int32> ints) : base
	(
		new SignedWithValues(
			new IsPositiveInt32(ints), 
			new NaturalFromInt32(ints))
	)
	{
	}
}
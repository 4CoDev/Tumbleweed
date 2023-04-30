using Tumbleweed.Numbers.Integers.Natural.FromSystem;
using Tumbleweed.Numbers.Real.Binaries.FromSystem.FromInts32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.FromSystem;

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
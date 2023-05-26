using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.FromSystem;

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
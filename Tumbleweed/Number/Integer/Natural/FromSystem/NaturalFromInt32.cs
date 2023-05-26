using Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Natural.FromSystem;

public sealed class NaturalFromInt32 : NaturalEnvelope
{
	public NaturalFromInt32(Int32 integer) : this
	(
		new ScalarValue<Int32>(integer)
	)
	{
	}
	
	public NaturalFromInt32(IScalar<Int32> integer) : base
	(
		new NaturalWithBits(
			new NaturalOfInt32(integer))
	)
	{
	}
}
using Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public sealed class NaturalFromInt32 : NaturalEnvelope
{
	public NaturalFromInt32(Int32 integer) : this
	(
		new ScalarOfValue<Int32>(integer)
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
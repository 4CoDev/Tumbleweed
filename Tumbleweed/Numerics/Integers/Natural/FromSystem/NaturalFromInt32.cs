using Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public sealed class NaturalFromInt32 : NaturalEnvelope
{
	public NaturalFromInt32(int integer) : this
	(
		new ScalarOfValue<int>(integer)
	)
	{
	}
	
	public NaturalFromInt32(IScalar<int> integer) : base
	(
		new NaturalWithBits(
			new NaturalOfInt32(integer))
	)
	{
	}
}
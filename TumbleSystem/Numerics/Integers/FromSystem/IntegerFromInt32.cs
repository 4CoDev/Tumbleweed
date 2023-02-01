using TumbleSystem.Numerics.Bits;
using TumbleSystem.Numerics.Bits.FromSystem;
using TumbleSystem.Numerics.Bits.FromSystem.FromInts32;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.FromSystem;

public class IntegerFromInt32 : IntegerEnvelope
{
	public IntegerFromInt32(int integer) : this
	(
		new ScalarOfValue<int>(integer)
	)
	{
	}

	public IntegerFromInt32(IScalar<int> integer) : base
	(
		new IntegerWithValues(
			new IsPositiveInt32(integer), 
			new NaturalOfInt32(integer))
	)
	{
	}
}
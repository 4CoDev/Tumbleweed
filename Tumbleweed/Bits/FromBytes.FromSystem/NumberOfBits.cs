using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class NumberOfBits : IScalar<int>
{
	public int Value()
	{
		return new ScalarOfValue<int>(8).Value();
	}
}
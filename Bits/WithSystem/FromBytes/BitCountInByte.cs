using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem.FromBytes;

public sealed class BitCountInByte : IScalar<int>
{
	public int Value()
	{
		return new ScalarOfValue<int>(8).Value();
	}
}
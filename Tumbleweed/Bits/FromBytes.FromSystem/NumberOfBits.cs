using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class NumberOfBits : IScalar<Int32>
{
	public Int32 Value => new ScalarValue<Int32>(8).Value;
}
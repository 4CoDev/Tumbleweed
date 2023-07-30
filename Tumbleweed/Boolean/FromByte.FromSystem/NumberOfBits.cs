using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.Boolean.FromByte.FromSystem;

public sealed class NumberOfBits : Any<Int32>
{
	public Int32 Value => new Value<Int32>(8).Value;
}
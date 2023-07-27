using Tumbleweed.Scalar;

namespace Tumbleweed.Boolean.FromByte.FromSystem;

public sealed class NumberOfBits : Any<Int32>
{
	public Int32 Value => new Tumbleweed.Scalar.Of.Value<Int32>(8).Value;
}
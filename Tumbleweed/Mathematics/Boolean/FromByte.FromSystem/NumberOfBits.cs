using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

public sealed class NumberOfBits : Any<Int32>
{
	public Int32 Value => new One<Int32>(8).Value;
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;

public sealed class Int32From64 : ScalarEnvelope<Int32>
{
	public Int32From64(IScalar<Int64> integer) : base
	(
		new ValueOfFunction<Int32>(
			() => (Int32) integer.Value)
	)
	{
	}
}
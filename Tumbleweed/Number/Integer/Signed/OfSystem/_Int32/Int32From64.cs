using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.OfSystem._Int32;

public sealed class Int32From64 : ScalarEnvelope<Int32>
{
	public Int32From64(IScalar<Int64> integer) : base
	(
		new ResultOfFunction<Int32>(
			() => (Int32) integer.Value)
	)
	{
	}
}
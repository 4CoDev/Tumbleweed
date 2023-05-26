using Tumbleweed._Enumerable;
using Tumbleweed.ReadOnlySpan;
using Tumbleweed.ReadOnlySpan.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.OfSystem._Int32;

public sealed class Int32FromBytes : ScalarEnvelope<Int32>
{
	public Int32FromBytes(IEnumerable<IScalar<Byte>> bytes) : this
	(
		new ValuesOfScalars<Byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IEnumerable<Byte> bytes) : this
	(
		new SpanFromEnumerable<Byte>(bytes)
	)
	{
	}
	
	public Int32FromBytes(IReadOnlySpan<Byte> bytes) : base
	(
		new ResultOfFunction<Int32>(
			() => BitConverter.ToInt32(
				new SpanWithSize<Byte>(bytes, 4).Value))
	)
	{
	}
}
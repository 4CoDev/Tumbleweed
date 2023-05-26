using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed._Byte.ToSystem;

public sealed class BytesFromChunkedBits : EnumerableEnvelope<Byte>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new ValuesOfScalars<Byte>(
			new SelectedByExpression<IEnumerable<IBoolean>, IScalar<Byte>>(
				bytes,
				@byte => new ByteFromBits(@byte)))
	)
	{
	}
}
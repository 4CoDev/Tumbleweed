using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public sealed class BitOfDelegate : BitEnvelope
{
	public BitOfDelegate(Func<IBit> @delegate) : base
	(
		new BitOfScalar(
			new ScalarOfDelegate<IBit>(@delegate))
	)
	{
	}
}
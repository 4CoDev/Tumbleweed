using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.OfSystem;

public sealed class BooleanOfDelegate : ScalarEnvelope<bool>
{
	public BooleanOfDelegate(Func<bool> @delegate) : base
	(
		new ValueOfDelegate<bool>(@delegate)
	)
	{
	}
}
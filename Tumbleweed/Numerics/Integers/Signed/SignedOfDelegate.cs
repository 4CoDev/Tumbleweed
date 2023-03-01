using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedOfDelegate : SignedEnvelope
{
	public SignedOfDelegate(Func<ISignedInteger> @delegate) : base
	(
		new SignedOfScalar(
			new ValueOfDelegate<ISignedInteger>(@delegate))
	)
	{
	}
}
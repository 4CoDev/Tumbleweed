using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedOfFunction : SignedEnvelope
{
	public SignedOfFunction(Func<ISignedInteger> @delegate) : base
	(
		new SignedOfScalar(
			new ValueOfFunction<ISignedInteger>(@delegate))
	)
	{
	}
}
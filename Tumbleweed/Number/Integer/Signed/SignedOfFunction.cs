using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed;

public sealed class SignedOfFunction : SignedEnvelope
{
	public SignedOfFunction(Func<ISigned> @delegate) : base
	(
		new SignedOfScalar(
			new ResultOfFunction<ISigned>(@delegate))
	)
	{
	}
}
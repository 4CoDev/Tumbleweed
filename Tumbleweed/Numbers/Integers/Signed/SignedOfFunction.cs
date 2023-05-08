using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed;

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
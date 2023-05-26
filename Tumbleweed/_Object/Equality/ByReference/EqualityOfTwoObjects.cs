using Tumbleweed._Boolean;

namespace Tumbleweed._Object.Equality.ByReference;

public sealed class EqualityOfTwoObjects : BooleanEnvelope
{
	public EqualityOfTwoObjects
	(
		Object first,
		Object second
	) : base
	(
		new EqualityOfTwoNullables(first, second)
	)
	{
	}
}
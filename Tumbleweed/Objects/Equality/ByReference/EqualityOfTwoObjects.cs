using Tumbleweed.Booleans;

namespace Tumbleweed.Objects.Equality.ByReference;

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
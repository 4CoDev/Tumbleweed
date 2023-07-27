using Tumbleweed.Boolean;

namespace Tumbleweed.Object.Equality.ByReference;

public sealed class EqualityOfTwoObjects : Envelope
{
	public EqualityOfTwoObjects
	(
		System.Object first,
		System.Object second
	) : base
	(
		new EqualityOfTwoNullables(first, second)
	)
	{
	}
}
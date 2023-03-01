using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Integers.Signed.FromSystem;

public class SignedsFromInts32 : EnumerableEnvelope<ISignedInteger>
{
	public SignedsFromInts32(params int[] ints) : this
	(
		new EnumerableWithElements<int>(ints)
	)
	{
	}

	public SignedsFromInts32(IEnumerable<int> ints) : base
	(
		new SelectedByExpression<int, ISignedInteger>(
			ints,
			@int => new SignedFromInt32(@int))
	)
	{
	}
}
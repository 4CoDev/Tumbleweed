using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Integers.Signed.FromSystem;

public class SignedsFromInts32 : EnumerableEnvelope<ISignedInteger>
{
	public SignedsFromInts32(params Int32[] ints) : this
	(
		new EnumerableWithElements<Int32>(ints)
	)
	{
	}

	public SignedsFromInts32(IEnumerable<Int32> ints) : base
	(
		new SelectedByExpression<Int32, ISignedInteger>(
			ints,
			@int => new SignedFromInt32(@int))
	)
	{
	}
}
using Tumbleweed._Enumerable;

namespace Tumbleweed.Number.Integer.Signed.FromSystem;

public class SignedsFromInts32 : EnumerableEnvelope<ISigned>
{
	public SignedsFromInts32(params Int32[] ints) : this
	(
		new EnumerableWithElements<Int32>(ints)
	)
	{
	}

	public SignedsFromInts32(IEnumerable<Int32> ints) : base
	(
		new SelectedByExpression<Int32, ISigned>(
			ints,
			@int => new SignedFromInt32(@int))
	)
	{
	}
}
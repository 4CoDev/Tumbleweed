using Tumbleweed._Enumerable;

namespace Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

public sealed class Ints32FromSigneds : EnumerableEnvelope<Int32>
{
	public Ints32FromSigneds(params ISigned[] integers) : this
	(
		new EnumerableWithElements<ISigned>(integers)
	)
	{
	}

	public Ints32FromSigneds(IEnumerable<ISigned> integers) : base
	(
		new SelectedByExpression<ISigned, Int32>(
			integers,
			integer => new Int32FromSigned(integer).Value)
	)
	{
	}

}
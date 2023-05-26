using Tumbleweed._Enumerable;

namespace Tumbleweed.Number.Integer.Natural.ToSystem;

public sealed class Ints32FromNaturals : EnumerableEnvelope<Int32>
{
	public Ints32FromNaturals(params INatural[] integers) : this
	(
		new EnumerableWithElements<INatural>(integers)
	)
	{
	}

	public Ints32FromNaturals(IEnumerable<INatural> naturals) : base
	(
		new SelectedByExpression<INatural, Int32>(
			naturals,
			natural => new Int32FromNatural(natural).Value)
	)
	{
	}

}
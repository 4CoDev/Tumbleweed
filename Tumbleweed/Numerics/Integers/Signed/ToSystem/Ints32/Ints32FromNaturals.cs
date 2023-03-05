using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Ints32FromNaturals : EnumerableEnvelope<int>
{
	public Ints32FromNaturals(params INaturalInteger[] integers) : this
	(
		new EnumerableWithElements<INaturalInteger>(integers)
	)
	{
	}

	public Ints32FromNaturals(IEnumerable<INaturalInteger> naturals) : base
	(
		new SelectedByExpression<INaturalInteger, int>(
			naturals,
			natural => new Int32FromNatural(natural).Value)
	)
	{
	}

}
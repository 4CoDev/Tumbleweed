using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Ints32FromNaturals : EnumerableEnvelope<Int32>
{
	public Ints32FromNaturals(params INaturalInteger[] integers) : this
	(
		new EnumerableWithElements<INaturalInteger>(integers)
	)
	{
	}

	public Ints32FromNaturals(IEnumerable<INaturalInteger> naturals) : base
	(
		new SelectedByExpression<INaturalInteger, Int32>(
			naturals,
			natural => new Int32FromNatural(natural).Value)
	)
	{
	}

}
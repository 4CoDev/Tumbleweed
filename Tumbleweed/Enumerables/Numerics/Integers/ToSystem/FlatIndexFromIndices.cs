using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.ToSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<int>
{
	public FlatIndexFromIndices
	(
		IEnumerable<INaturalInteger> indices,
		IEnumerable<INaturalInteger> dimensions
	) : base
	(
		new OfSystem.FlatIndexFromIndices(
			new Ints32FromNaturals(indices),
			new Ints32FromNaturals(dimensions))
	)
	{
	}
}
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.ToSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<Int32>
{
	public FlatIndexFromIndices
	(
		IEnumerable<INatural> indices,
		IEnumerable<INatural> dimensions
	) : base
	(
		new OfSystem.FlatIndexFromIndices(
			new Ints32FromNaturals(indices),
			new Ints32FromNaturals(dimensions))
	)
	{
	}
}
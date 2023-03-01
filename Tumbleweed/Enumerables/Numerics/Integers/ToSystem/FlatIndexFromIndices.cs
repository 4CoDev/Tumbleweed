using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.ToSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<int>
{
	public FlatIndexFromIndices
	(
		IEnumerable<ISignedInteger> indices,
		IEnumerable<ISignedInteger> dimensions
	) : base
	(
		new OfSystem.FlatIndexFromIndices(
			new Ints32FromSigneds(indices),
			new Ints32FromSigneds(dimensions))
	)
	{
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.OfSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<int>
{
	public FlatIndexFromIndices
	(
		IEnumerable<int> indices,
		IEnumerable<int> dimensions
	) : base
	(
		new Collections.Numerics.Integers.FromSystem.FlatIndexFromIndices(
			new List<int>(indices),
			new List<int>(dimensions))
	)
	{
	}
}
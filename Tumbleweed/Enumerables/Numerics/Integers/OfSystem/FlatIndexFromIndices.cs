using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Numerics.Integers.OfSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<Int32>
{
	public FlatIndexFromIndices
	(
		IEnumerable<Int32> indices,
		IEnumerable<Int32> dimensions
	) : base
	(
		new Collections.Numerics.Integers.FromSystem.FlatIndexFromIndices(
			new List<Int32>(indices),
			new List<Int32>(dimensions))
	)
	{
	}
}
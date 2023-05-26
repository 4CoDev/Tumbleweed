using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Number.Integer.ToSystem;

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
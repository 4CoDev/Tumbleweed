using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;

namespace Tumbleweed._Enumerable.Number.Integer;

public sealed class FlatIndexFromIndices : NaturalEnvelope
{
	public FlatIndexFromIndices
	(
		IEnumerable<INatural> indices,
		IEnumerable<INatural> dimensions
	) : base
	(
		new NaturalFromInt32(
			new ToSystem.FlatIndexFromIndices(indices, dimensions))
	)
	{
	}
}
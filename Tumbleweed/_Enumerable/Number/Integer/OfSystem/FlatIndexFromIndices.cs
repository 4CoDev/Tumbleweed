using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Number.Integer.OfSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<Int32>
{
	public FlatIndexFromIndices
	(
		IEnumerable<Int32> indices,
		IEnumerable<Int32> dimensions
	) : base
	(
		new _Collection.Number.Integer.FromSystem.FlatIndexFromIndices(
			new List<Int32>(indices),
			new List<Int32>(dimensions))
	)
	{
	}
}
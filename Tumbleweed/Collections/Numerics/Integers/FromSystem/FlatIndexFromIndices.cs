using Tumbleweed.Scalars;

namespace Tumbleweed.Collections.Numerics.Integers.FromSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<int>
{
	public FlatIndexFromIndices
	(
		ICollection<int> indices,
		ICollection<int> dimensions
	) : base
	(
		new ValueOfDelegate<int>(() => Result(indices, dimensions))
	)
	{
	}

	private static int Result
	(
		ICollection<int> indices,
		ICollection<int> dimensions
	)
	{
		if (indices.Count > dimensions.Count)
		{
			throw new InvalidOperationException("Indices go beyond dimensions.");
		}
		int modifier = 1;
		int result = 0;
		for (int i = 0; i < indices.Count; i++)
		{
			int index = indices.ElementAt(i);
			int dimension = dimensions.ElementAt(i);
			result += index * modifier;
			modifier *= dimension;
		}
		return result;
	}
}
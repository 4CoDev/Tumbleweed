using Tumbleweed.Scalars;

namespace Tumbleweed.Collections.Numerics.Integers.FromSystem;

public sealed class FlatIndexFromIndices : ScalarEnvelope<Int32>
{
	public FlatIndexFromIndices
	(
		ICollection<Int32> indices,
		ICollection<Int32> dimensions
	) : base
	(
		new ResultOfFunction<Int32>(() => Result(indices, dimensions))
	)
	{
	}

	private static Int32 Result
	(
		ICollection<Int32> indices,
		ICollection<Int32> dimensions
	)
	{
		if (indices.Count > dimensions.Count)
		{
			throw new InvalidOperationException("Indices go beyond dimensions.");
		}
		Int32 modifier = 1;
		Int32 result = 0;
		for (Int32 i = 0; i < indices.Count; i++)
		{
			Int32 index = indices.ElementAt(i);
			Int32 dimension = dimensions.ElementAt(i);
			result += index * modifier;
			modifier *= dimension;
		}
		return result;
	}
}
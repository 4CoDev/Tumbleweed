using Tumbleweed.Enumerables.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Arrays.FromEnumerable;

public sealed class MultidimensionalArray<T> : IArray<T>
{
	public MultidimensionalArray
	(
		IEnumerable<T> elements,
		IEnumerable<INaturalInteger> dimensions
	)
	{
		this.elements = elements;
		this.dimensions = dimensions;
	}

	public T this[IEnumerable<INaturalInteger> indices] =>
	(
		new ElementAtIndex<T>(
			elements,
			new FlatIndexFromIndices(indices, dimensions)).Value
	);

	private readonly IEnumerable<T> elements;

	private readonly IEnumerable<INaturalInteger> dimensions;
}
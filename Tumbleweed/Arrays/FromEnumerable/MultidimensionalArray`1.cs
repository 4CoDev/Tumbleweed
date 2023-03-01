using Tumbleweed.Enumerables.Numerics.Integers;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Arrays.FromEnumerable;

public sealed class MultidimensionalArray<T> : IArray<T>
{
	public MultidimensionalArray
	(
		IEnumerable<T> elements,
		IEnumerable<ISignedInteger> dimensions
	)
	{
		this.elements = elements;
		this.dimensions = dimensions;
	}

	public T this[IEnumerable<ISignedInteger> indices]
	{
		get => new ScalarAtIndex<T>(
			elements,
			new FlatIndexFromIndices(indices, dimensions)).Value;
	}

	private readonly IEnumerable<T> elements;

	private readonly IEnumerable<ISignedInteger> dimensions;
}
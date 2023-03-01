using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromEnumerable;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Arrays.Linears;

public sealed class ArrayFromEnumerable<T> : IArray<T>
{
	public ArrayFromEnumerable
	(
		IEnumerable<T> enumerable
	)
	{
		this.enumerable = enumerable;
	}

	public T this[IEnumerable<ISignedInteger> indices]
	{
		get => new ScalarAtIndex<T>(
			enumerable,
			new SingleElementOfEnumerable(indices)).Value;
	}

	private readonly IEnumerable<T> enumerable;
}
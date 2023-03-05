using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays;

public sealed class ArrayOfScalar<T> : IArray<T>
{
	public ArrayOfScalar(IScalar<IArray<T>> scalar) =>
		this.scalar = scalar;
	
	public T this[IEnumerable<INaturalInteger> indices] =>
		scalar.Value[indices];

	private readonly IScalar<IArray<T>> scalar;
}
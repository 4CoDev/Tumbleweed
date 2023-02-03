using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem.Scalar;

public sealed class ChunkedBySize<T> : IScalar<IEnumerable<IEnumerable<T>>>
{
	public ChunkedBySize(IEnumerable<T> enumerable, IScalar<int> size)
	{
		this.enumerable = enumerable;
		this.size = size;
	}

	public IEnumerable<IEnumerable<T>> Value()
	{
		return enumerable.Chunk(size.Value());
	}

	private readonly IEnumerable<T> enumerable;

	private readonly IScalar<int> size;
}
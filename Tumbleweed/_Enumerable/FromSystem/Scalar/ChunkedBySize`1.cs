using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem.Scalar;

public sealed class ChunkedBySize<T> : IScalar<IEnumerable<IEnumerable<T>>>
{
	public ChunkedBySize(IEnumerable<T> enumerable, IScalar<Int32> size)
	{
		this.enumerable = enumerable;
		this.size = size;
	}

	public IEnumerable<IEnumerable<T>> Value => enumerable.Chunk(size.Value);

	private readonly IEnumerable<T> enumerable;

	private readonly IScalar<Int32> size;
}
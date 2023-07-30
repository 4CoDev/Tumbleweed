using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.Chunked.By.Length;

public sealed class System<T> : Enumerable::Envelope<IEnumerable<T>>
{
	public System
	(
		IEnumerable<T> enumerable,
		Any<Int32> size
	) : base
	(
		new Enumerable::Function.Result<IEnumerable<T>>(
			() => enumerable.Chunk(size.Value))
	)
	{
	}
}
using Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;

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
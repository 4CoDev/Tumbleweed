using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public sealed class NonExistent<T> : INullable<T>
{
	public T Value =>
		throw new NullReferenceException("That object does not exist");

	public IBit Exists => new NegativeBit();
}
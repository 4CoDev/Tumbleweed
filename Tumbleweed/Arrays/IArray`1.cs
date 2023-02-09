using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Arrays;

public interface IArray<out T>
{
	T this[IEnumerable<IInteger> indices] { get; }
}
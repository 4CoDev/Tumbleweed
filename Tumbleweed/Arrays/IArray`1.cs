using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Arrays;

public interface IArray<out T>
{
	T this[IEnumerable<INaturalInteger> indices] { get; }
}
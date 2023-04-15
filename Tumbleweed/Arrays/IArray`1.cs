using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Arrays;

public interface IArray<T>
{
	T this[IEnumerable<INaturalInteger> indices] { get; set; }
	
	IEnumerable<INaturalInteger> Size { get; }
}
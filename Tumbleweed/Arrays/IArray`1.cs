using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Arrays;

public interface IArray<T>
{
	T this[IEnumerable<INatural> indices] { get; set; }
	
	IEnumerable<INatural> Size { get; }
}
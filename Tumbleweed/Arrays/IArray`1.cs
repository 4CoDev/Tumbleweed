namespace Tumbleweed.Arrays;

using INaturalNumber = Numbers.Integers.Natural.INatural;

public interface IArray<T>
{
	T this[IEnumerable<INaturalNumber> indices] { get; set; }
	
	IEnumerable<INaturalNumber> Size { get; }
}
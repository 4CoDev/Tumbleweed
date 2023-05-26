using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Array;

using INaturalNumber = INatural;

public interface IArray<T>
{
	T this[IEnumerable<INaturalNumber> indices] { get; set; }
	
	IEnumerable<INaturalNumber> Size { get; }
}
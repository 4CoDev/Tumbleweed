using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Arrays;

public interface IArray<out T>
{
	T this[IEnumerable<ISignedInteger> indices] { get; }
}
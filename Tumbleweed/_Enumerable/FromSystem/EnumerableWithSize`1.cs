using Tumbleweed._Collection.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.FromSystem;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize(IEnumerable<T> enumerable, Int32 size) : this
	(
		enumerable, new ScalarValue<Int32>(size)
	)
	{
	}
	
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}
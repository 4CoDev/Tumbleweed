using Tumbleweed._Enumerable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.Hash;

public sealed class HashFromNullables : ScalarEnvelope<Int32>
{
	public HashFromNullables(params Object?[] objects) : this
	(
		new EnumerableWithElements<Object?>(objects)
	)
	{
	}

	public HashFromNullables(IEnumerable<Object?> objects) : this
	(
		new NullablesFromSystem<Object>(objects)
	)
	{
	}
	
	public HashFromNullables(params INullable<Object>[] objects) : this
	(
		new EnumerableWithElements<INullable<Object>>(objects)
	)
	{
	}
	
	public HashFromNullables(IEnumerable<INullable<Object>> objects) : base
	(
		new HashFromHashes(
			new ZeroHashesWhenNull(objects))
	)
	{
	}
}
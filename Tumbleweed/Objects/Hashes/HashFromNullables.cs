using Tumbleweed.Enumerables;
using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Objects.Hashes;

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
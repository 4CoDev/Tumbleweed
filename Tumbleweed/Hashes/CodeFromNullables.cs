using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeFromNullables : ScalarEnvelope<Int32>
{
	public CodeFromNullables(params Object?[] objects) : this
	(
		new EnumerableWithElements<Object?>(objects)
	)
	{
	}
	
	public CodeFromNullables(IEnumerable<Object?> objects) : base
	(
		new ValueOfDelegate<Int32>(
			() => HashCode.Combine(objects))
	)
	{
	}
}
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeFromNullables : ScalarEnvelope<int>
{
	public CodeFromNullables(params object?[] objects) : this
	(
		new EnumerableWithElements<object?>(objects)
	)
	{
	}
	
	public CodeFromNullables(IEnumerable<object?> objects) : base
	(
		new ValueOfDelegate<int>(
			() => HashCode.Combine(objects))
	)
	{
	}
}
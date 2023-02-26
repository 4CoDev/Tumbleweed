using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeFromObjects : ScalarEnvelope<int>
{
	public CodeFromObjects(params object[] objects) : this
	(
		new EnumerableWithElements<object>(objects)
	)
	{
	}
	
	public CodeFromObjects(IEnumerable<object> objects) : base
	(
		new ValueOfDelegate<int>(
			() => HashCode.Combine(objects))
	)
	{
	}
}
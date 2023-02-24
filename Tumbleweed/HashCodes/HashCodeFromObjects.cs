using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.HashCodes;

public sealed class HashCodeFromObjects : ScalarEnvelope<int>
{
	public HashCodeFromObjects(params object[] objects) : this
	(
		new EnumerableWithElements<object>(objects)
	)
	{
	}
	
	public HashCodeFromObjects(IEnumerable<object> objects) : base
	(
		new ScalarOfDelegate<int>(
			() => HashCode.Combine(objects))
	)
	{
	}
}
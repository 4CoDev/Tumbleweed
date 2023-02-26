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
		new ValueOfDelegate<int>(
			() => HashCode.Combine(objects))
	)
	{
	}
}
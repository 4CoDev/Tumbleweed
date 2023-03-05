using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeFromObjects : ScalarEnvelope<Int32>
{
	public CodeFromObjects(params Object[] objects) : this
	(
		new EnumerableWithElements<Object>(objects)
	)
	{
	}
	
	public CodeFromObjects(IEnumerable<Object> objects) : base
	(
		new CodeFromNullables(objects)
	)
	{
	}
}
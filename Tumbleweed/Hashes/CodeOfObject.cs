using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfObject : ScalarEnvelope<int>
{
	public CodeOfObject(object @object) : base
	(
		new ValueOfDelegate<int>(@object.GetHashCode)
	)
	{
	}
}
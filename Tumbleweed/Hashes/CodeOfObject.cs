using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfObject : ScalarEnvelope<int>
{
	public CodeOfObject(object @object) : this
	(
		new ScalarOfValue<object>(@object)
	)
	{
	}
	
	public CodeOfObject(IScalar<object> @object) : base
	(
		new ValueOfDelegate<int>(
			() => @object.Value.GetHashCode())
	)
	{
	}
}
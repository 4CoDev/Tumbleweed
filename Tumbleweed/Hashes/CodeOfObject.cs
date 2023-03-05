using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfObject : ScalarEnvelope<Int32>
{
	public CodeOfObject(Object @object) : this
	(
		new ScalarOfValue<Object>(@object)
	)
	{
	}
	
	public CodeOfObject(IScalar<Object> @object) : base
	(
		new ValueOfDelegate<Int32>(
			() => @object.Value.GetHashCode())
	)
	{
	}
}
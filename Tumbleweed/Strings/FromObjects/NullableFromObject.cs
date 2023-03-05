using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromObject : ScalarEnvelope<string?>
{
	public NullableFromObject(Object @object) : this
	(
		new ScalarOfValue<Object>(@object)
	)
	{
	}
	
	public NullableFromObject(IScalar<Object> @object) : base
	(
		new ValueOfDelegate<string?>(
			() => @object.Value.ToString())
	)
	{
	}
}
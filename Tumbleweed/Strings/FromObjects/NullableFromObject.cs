using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromObject : ScalarEnvelope<String?>
{
	public NullableFromObject(Object @object) : this
	(
		new ScalarOfValue<Object>(@object)
	)
	{
	}
	
	public NullableFromObject(IScalar<Object> @object) : base
	(
		new ValueOfFunction<String?>(
			() => @object.Value.ToString())
	)
	{
	}
}
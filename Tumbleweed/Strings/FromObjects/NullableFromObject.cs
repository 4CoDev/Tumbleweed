using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromObject : ScalarEnvelope<string?>
{
	public NullableFromObject(object @object) : this
	(
		new ScalarOfValue<object>(@object)
	)
	{
	}
	
	public NullableFromObject(IScalar<object> @object) : base
	(
		new ValueOfDelegate<string?>(
			() => @object.Value.ToString())
	)
	{
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class ObjectAsNullableString : ScalarEnvelope<string?>
{
	public ObjectAsNullableString(object @object) : this
	(
		new ScalarOfValue<object>(@object)
	)
	{
	}

	public ObjectAsNullableString(IScalar<object> @object) : base
	(
		new ScalarOfDelegate<string?>(@object.ToString)
	)
	{
	}
}
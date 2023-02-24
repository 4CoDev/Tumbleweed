using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

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
		new ScalarOfDelegate<string?>(@object.ToString)
	)
	{
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromObject : ScalarEnvelope<string?>
{
	public NullableFromObject(object @object) : base
	(
		new ValueOfDelegate<string?>(@object.ToString)
	)
	{
	}
}
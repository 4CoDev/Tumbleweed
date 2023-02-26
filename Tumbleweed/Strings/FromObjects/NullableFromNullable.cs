using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromNullable : ScalarEnvelope<string?>
{
	public NullableFromNullable(object? @object) : base
	(
		new ValueOfDelegate<string?>(
			() => @object?.ToString())
	)
	{
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromNullable : ScalarEnvelope<string?>
{
	public NullableFromNullable(object? @object) : this
	(
		new ScalarOfValue<object?>(@object)
	)
	{
	}
	
	public NullableFromNullable(IScalar<object?> @object) : base
	(
		new ValueOfDelegate<string?>(
			() => @object.Value?.ToString())
	)
	{
	}
}
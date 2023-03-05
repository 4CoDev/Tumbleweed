using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromNullable : ScalarEnvelope<string?>
{
	public NullableFromNullable(Object? @object) : this
	(
		new ScalarOfValue<Object?>(@object)
	)
	{
	}
	
	public NullableFromNullable(IScalar<Object?> @object) : base
	(
		new ValueOfDelegate<string?>(
			() => @object.Value?.ToString())
	)
	{
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromNullable : ScalarEnvelope<String?>
{
	public NullableFromNullable(Object? @object) : this
	(
		new ScalarOfValue<Object?>(@object)
	)
	{
	}
	
	public NullableFromNullable(IScalar<Object?> @object) : base
	(
		new ValueOfFunction<String?>(
			() => @object.Value?.ToString())
	)
	{
	}
}
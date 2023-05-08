using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class NullableFromNullable : ScalarEnvelope<String?>
{
	public NullableFromNullable(Object? @object) : this
	(
		new ScalarValue<Object?>(@object)
	)
	{
	}
	
	public NullableFromNullable(IScalar<Object?> @object) : base
	(
		new ResultOfFunction<String?>(
			() => @object.Value?.ToString())
	)
	{
	}
}
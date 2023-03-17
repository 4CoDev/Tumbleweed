using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfNullable : ScalarEnvelope<Int32>
{
	public CodeOfNullable(Object? @object) : this
	(
		new ScalarOfValue<Object?>(@object)
	)
	{
	}
	
	public CodeOfNullable(IScalar<Object?> @object) : base
	(
		new ValueOfFunction<Int32>(
			() => Function(@object.Value))
	)
	{
	}

	private static Int32 Function(Object? @object)
	{
		if (@object == null) return 0;
		return @object.GetHashCode();
	}
}
using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfNullable : ScalarEnvelope<int>
{
	public CodeOfNullable(object? @object) : this
	(
		new ScalarOfValue<object?>(@object)
	)
	{
	}
	
	public CodeOfNullable(IScalar<object?> @object) : base
	(
		new ValueOfDelegate<int>(
			() => Function(@object.Value))
	)
	{
	}

	private static int Function(object? @object)
	{
		if (@object == null) return 0;
		return @object.GetHashCode();
	}
}
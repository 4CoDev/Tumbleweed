using Tumbleweed.Scalars;

namespace Tumbleweed.Hashes;

public sealed class CodeOfNullable : ScalarEnvelope<int>
{
	public CodeOfNullable(object? @object) : base
	(
		new ValueOfDelegate<int>(
			() => Function(@object))
	)
	{
	}

	private static int Function(object? @object)
	{
		if (@object == null) return 0;
		return @object.GetHashCode();
	}
}
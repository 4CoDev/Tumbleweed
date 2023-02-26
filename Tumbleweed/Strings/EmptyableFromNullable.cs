using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class EmptyableFromNullable : ScalarEnvelope<string>
{
	public EmptyableFromNullable(string? nullable) : this
	(
		new ScalarOfValue<string?>(nullable)
	)
	{
	}
	
	public EmptyableFromNullable(IScalar<string?> nullable) : base
	(
		new ValueOfDelegate<string>(() => nullable.Value ?? "")
	)
	{
	}
}
using Tumbleweed._Boolean;

namespace Tumbleweed.Nullable;

public sealed class IsValueExists : BooleanEnvelope
{
	public IsValueExists(INullable<Object> nullable) : base
	(
		new BooleanOfFunction(
			() => nullable.Existing)
	)
	{
	}
}
using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Boolean;

public sealed class False : BooleanEnvelope
{
	public False() : base
	(
		new BooleanFromSystem(false)
	)
	{
	}
}
using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Booleans;

public sealed class False : BooleanEnvelope
{
	public False() : base
	(
		new BooleanFromSystem(false)
	)
	{
	}
}
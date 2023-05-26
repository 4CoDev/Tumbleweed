using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Boolean;

public sealed class True : BooleanEnvelope
{
	public True() : base
	(
		new BooleanFromSystem(true)
	)
	{
	}
}
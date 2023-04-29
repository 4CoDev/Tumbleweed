using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Booleans;

public sealed class True : BooleanEnvelope
{
	public True() : base
	(
		new BooleanFromSystem(true)
	)
	{
	}
}
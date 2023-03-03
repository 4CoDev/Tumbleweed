using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class EmptyWhenNull : ScalarEnvelope<string>
{
	public EmptyWhenNull(string? nullable) : this
	(
		new ScalarOfValue<string?>(nullable)
	)
	{
	}
	
	public EmptyWhenNull(IScalar<string?> nullable) : base
	(
		new WordWhenNull(nullable, "")
	)
	{
	}
}
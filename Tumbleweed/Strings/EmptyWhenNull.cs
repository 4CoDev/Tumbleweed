using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class EmptyWhenNull : ScalarEnvelope<String>
{
	public EmptyWhenNull(String? nullable) : this
	(
		new ScalarOfValue<String?>(nullable)
	)
	{
	}
	
	public EmptyWhenNull(IScalar<String?> nullable) : base
	(
		new WordWhenNull(nullable, "")
	)
	{
	}
}
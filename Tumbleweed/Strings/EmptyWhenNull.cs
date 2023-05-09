using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class EmptyWhenNull : ScalarEnvelope<String>
{
	public EmptyWhenNull(String? nullable) : this
	(
		new NullableFromSystem<String>(nullable)
	)
	{
	}
	
	public EmptyWhenNull(INullable<String> nullable) : base
	(
		new SpareWhenNull(nullable, "")
	)
	{
	}
}
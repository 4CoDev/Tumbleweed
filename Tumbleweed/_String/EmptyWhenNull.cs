using Tumbleweed._String.Nullable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;

namespace Tumbleweed._String;

public sealed class EmptyWhenNull : StringEnvelope
{
	public EmptyWhenNull(String? nullable) : this
	(
		new NullableFromSystem<String>(nullable)
	)
	{
	}
	
	public EmptyWhenNull(INullable<String> nullable) : this
	(
		new NullableFromSystem(nullable)
	)
	{
	}
	
	public EmptyWhenNull(INullable<IString> nullable) : base
	(
		new SpareWhenStringIsNull(nullable, "")
	)
	{
	}
}
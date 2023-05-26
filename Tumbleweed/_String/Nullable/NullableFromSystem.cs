using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._String.Nullable;

public sealed class NullableFromSystem : NullableEnvelope<IString>
{
	public NullableFromSystem(String? nullable) : this
	(
		new NullableFromSystem<String>(nullable)
	)
	{
	}
	
	public NullableFromSystem(IScalar<String?> nullable) : this
	(
		new NullableFromSystem<String>(nullable)
	)
	{
	}
	
	public NullableFromSystem
	(
		INullable<String> nullable
	) : base
	(
		new NullableWithValues<IString>(
			new StringFromSystem(
				new ValueOfNullable<String>(nullable)),
			new IsValueExists(nullable))
	)
	{
	}
}
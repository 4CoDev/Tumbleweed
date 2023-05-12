using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class SpareWhenNull : ScalarEnvelope<String>
{
	public SpareWhenNull(String? nullable, String spare) : this
	(
		new NullableFromSystem<String>(nullable),
		new ScalarValue<String>(spare)
	)
	{
	}
	
	public SpareWhenNull
	(
		INullable<String> nullable,
		String spare
	) : this
	(
		nullable,
		new ScalarValue<String>(spare)
	)
	{
	}
	
	public SpareWhenNull
	(
		String? nullable,
		IScalar<String> spare
	) : this
	(
		new NullableFromSystem<String>(nullable),
		spare
	)
	{
	}
	
	public SpareWhenNull
	(
		INullable<String> nullable,
		IScalar<String> spare
	) : base
	(
		new SpareWhenNull<String>(nullable, spare)
	)
	{
	}
}
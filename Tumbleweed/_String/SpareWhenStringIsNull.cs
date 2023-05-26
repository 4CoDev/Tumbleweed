using Tumbleweed._String.Nullable;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._String;

public sealed class SpareWhenStringIsNull : StringEnvelope
{
	public SpareWhenStringIsNull
	(
		String? nullable,
		String spare
	) : this
	(
		new NullableFromSystem(nullable),
		new StringFromSystem(spare)
	)
	{
	}
	
	public SpareWhenStringIsNull
	(
		INullable<String> nullable,
		String spare
	) : this
	(
		new NullableFromSystem(nullable),
		spare
	)
	{
	}
	
	public SpareWhenStringIsNull
	(
		INullable<IString> nullable,
		String spare
	) : this
	(
		nullable,
		new StringFromSystem(spare)
	)
	{
	}
	
	public SpareWhenStringIsNull
	(
		IString? nullable,
		IString spare
	) : this
	(
		new NullableFromSystem<IString>(nullable),
		spare
	)
	{
	}
	
	public SpareWhenStringIsNull
	(
		INullable<IString> nullable,
		IString spare
	) : base
	(
		new StringOfScalar(
			new SpareWhenNull<IString>(nullable, spare))
	)
	{
	}
}
using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Scalars;
using Tumbleweed.Strings;

namespace Tumbleweed.Objects.Strings;

public sealed class SpareWhenObjectIsNull : ScalarEnvelope<String>
{
	public SpareWhenObjectIsNull(Object? @object, String spare) : this
	(
		new NullableFromSystem<Object>(@object),
		new ScalarValue<String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull(INullable<Object> @object, String spare) : this
	(
		@object,
		new ScalarValue<String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull(Object? @object, IScalar<String> spare) : this
	(
		new NullableFromSystem<Object>(@object),
		spare
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		INullable<Object> @object,
		IScalar<String> spare
	) : base
	(
		new SpareWhenNull(
			new StringFromNullableObject(@object),
			spare)
	)
	{
	}
}
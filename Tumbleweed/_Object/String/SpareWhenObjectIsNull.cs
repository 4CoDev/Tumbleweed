using Tumbleweed._String;
using Tumbleweed.Nullable;
using Tumbleweed.Nullable.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed._Object.String;

public sealed class SpareWhenObjectIsNull : StringEnvelope
{
	public SpareWhenObjectIsNull
	(
		Object? @object,
		System.String spare
	) : this
	(
		new NullableFromSystem<Object>(@object),
		new ScalarValue<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		INullable<Object> @object,
		System.String spare
	) : this
	(
		@object,
		new ScalarValue<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		Object? @object,
		IScalar<System.String> spare
	) : this
	(
		new NullableFromSystem<Object>(@object),
		new StringFromSystem(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		INullable<Object> @object,
		IString spare
	) : base
	(
		new SpareWhenStringIsNull(
			new StringFromNullableObject(@object),
			spare)
	)
	{
	}
}
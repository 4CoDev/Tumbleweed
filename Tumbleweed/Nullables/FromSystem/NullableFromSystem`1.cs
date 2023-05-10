using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Booleans.OfSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullables.FromSystem;

public sealed class NullableFromSystem<T> :
	NullableEnvelope<T>
{
	public NullableFromSystem(T? origin) : this
	(
		new ScalarValue<T?>(origin)
	)
	{
	}
	
	public NullableFromSystem(IScalar<T?> origin) : base
	(
		new NullableWithValues<T>(
			origin!,
			new BooleanFromSystem(
				new BooleanOfFunction(
					() => origin.Value != null)))
	)
	{
	}
}
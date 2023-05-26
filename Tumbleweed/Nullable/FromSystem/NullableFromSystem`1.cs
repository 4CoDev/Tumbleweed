using Tumbleweed._Boolean.FromSystem;
using Tumbleweed._Boolean.OfSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Nullable.FromSystem;

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
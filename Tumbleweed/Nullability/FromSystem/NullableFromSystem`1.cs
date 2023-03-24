using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Bits.OfSystem;

namespace Tumbleweed.Nullability.FromSystem;

public sealed class NullableFromSystem<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableFromSystem(T? origin) : base
	(
		new NullableWithValues<T>(
			origin!,
			new BitFromBoolean(
				new BooleanOfFunction(
					() => origin != null)))
	)
	{
	}
}
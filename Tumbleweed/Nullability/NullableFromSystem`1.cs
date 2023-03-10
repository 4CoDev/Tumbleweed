using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Bits.OfSystem;

namespace Tumbleweed.Nullability;

public sealed class NullableFromSystem<T> : NullableEnvelope<T>
{
	public NullableFromSystem(T? origin) : base
	(
		new NullableWithValues<T>(
			origin!,
			new BitFromBoolean(
				new BooleanOfDelegate(
					() => origin != null)))
	)
	{
	}
}
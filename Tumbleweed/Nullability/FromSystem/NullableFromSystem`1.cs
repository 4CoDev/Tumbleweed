using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Booleans.OfSystem;

namespace Tumbleweed.Nullability.FromSystem;

public sealed class NullableFromSystem<T> :
	NullableEnvelope<T>
	where T : notnull
{
	public NullableFromSystem(T? origin) : base
	(
		new NullableWithValues<T>(
			origin!,
			new BooleanFromSystem(
				new BooleanOfFunction(
					() => origin != null)))
	)
	{
	}
}
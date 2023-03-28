using Tumbleweed.Mutables;

namespace Tumbleweed.Scalars;

public sealed class ValueOfMutable<T> : ScalarEnvelope<T>
{
	public ValueOfMutable(IMutable<T> mutable) : base
	(
		new ValueOfFunction<T>(
			() => mutable.Value)
	)
	{
	}
}
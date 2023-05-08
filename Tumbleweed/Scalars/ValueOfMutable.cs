using Tumbleweed.Mutables;

namespace Tumbleweed.Scalars;

public sealed class ValueOfMutable<T> : ScalarEnvelope<T>
{
	public ValueOfMutable(IMutable<T> mutable) : base
	(
		new ResultOfFunction<T>(
			() => mutable.Variable)
	)
	{
	}
}
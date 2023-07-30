using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Array.Dimension.Linear.System.Length;

public sealed class System<T> : Tumbleweed.Scalar.Immutable.Envelope<Int32>
{
	public System(Tumbleweed.Scalar.Immutable.Any<T[]> array) : base
	(
		new Actual<Int32>(
			() => array.Value.Length)
	)
	{
	}
}
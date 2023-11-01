using Tumbleweed.Property.Output.Function.Result;

namespace Tumbleweed.Array.Dimension.Linear.System.Length;

public sealed class System<T> : Tumbleweed.Property.Output.Envelope<Int32>
{
	public System(Tumbleweed.Property.Output.Any<T[]> array) : base
	(
		new Actual<Int32>(
			() => array.Value.Length)
	)
	{
	}
}
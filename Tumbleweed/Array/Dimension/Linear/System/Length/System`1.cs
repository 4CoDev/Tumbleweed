namespace Tumbleweed.Array.Dimension.Linear.System.Length;

public sealed class System<T> : Tumbleweed.Scalar.Envelope<Int32>
{
	public System(Tumbleweed.Scalar.Any<T[]> array) : base
	(
		new Tumbleweed.Scalar.Function.Result<Int32>(
			() => array.Value.Length)
	)
	{
	}
}
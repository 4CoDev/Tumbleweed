using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.From.Array.Linear;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System(T[] array) : this
	(
		new Scalar::Of.Value<T[]>(array)
	)
	{
	}
	
	public System(Scalar::Any<T[]> array) : base
	(
		new Enumerable::Function.Result<T>(
			array.Value.AsEnumerable)
	)
	{
	}
}
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.From.Array.Spatial;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System(T[,,] array) : this
	(
		new Value<T[,,]>(array)
	)
	{
	}
	
	public System(Any<T[,,]> array) : base
	(
		new Enumerable::Function.Result<T>(
			array.Value.Cast<T>)
	)
	{
	}
}
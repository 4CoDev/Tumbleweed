using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Enumerable.From.Array.Spatial;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System(T[,,] array) : this
	(
		new One<T[,,]>(array)
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
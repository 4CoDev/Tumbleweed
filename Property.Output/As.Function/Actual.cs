using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Property.Output.As.Function;

public sealed class Actual<T> : Function::Envelope<T>
{
	public Actual(Property::Any<T> property) : base
	(
		new Function::From.System<T>(
			() => property.Value)
	)
	{
	}
}
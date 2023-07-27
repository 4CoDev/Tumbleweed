using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Boolean.Comparison.Both.Are;

public sealed class True : Boolean::Envelope
{
	public True
	(
		Boolean::Any first,
		Boolean::Any second
	) : base
	(
		new Boolean::From.System.One(
			new Boolean::System.Function.Result(
				() => first.State && second.State))
	)
	{
	}
}
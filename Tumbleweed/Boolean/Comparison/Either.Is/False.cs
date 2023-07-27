using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Boolean.Comparison.Either.Is;

public sealed class False : Boolean::Envelope
{
	public False
	(
		Boolean::Any first,
		Boolean::Any second
	) : base
	(
		new Boolean::From.System.One(
			new Boolean::System.Function.Result(
				() => !first.State || !second.State))
	)
	{
	}
}